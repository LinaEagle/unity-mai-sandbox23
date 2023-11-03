using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace Project.Classes._231102
{
    public class ProceduralAnimation : MonoBehaviour
    {
        public float delay = 2;
        [Range(0, 5)] public float duration;
        public AnimationCurve animationCurve;
        public Vector2 yPositionInterval = new Vector2(0,1);

        public Stopwatch _Stopwatch = new Stopwatch();
        private float _timer;

        private void Start()
        {
            var coroutine = StartCoroutine(AnimateAsync(null));
        }

        private void OnEnable()
        {
            _timer = 0;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                StopAllCoroutines();
            }
            
            if (_timer < duration)
            {
                var progress = _timer / duration;
                var t = animationCurve.Evaluate(progress);
                var startPosition = new Vector3(0, yPositionInterval.x, 0);
                var endPosition = new Vector3(0, yPositionInterval.y, 0);
                transform.localPosition = Vector3.Lerp(startPosition, endPosition, t);
                _timer += Time.deltaTime;
            }
            else
            {
                _timer = 0;
            }
        }

        private IEnumerator AnimateAsync(Action<float> onFinished)
        {
            yield return new WaitForSeconds(delay);
            
            while (_timer < duration)
            {
                var progress = _timer / duration;
                var t = animationCurve.Evaluate(progress);
                var startPosition = new Vector3(0, yPositionInterval.x, 0);
                var endPosition = new Vector3(0, yPositionInterval.y, 0);
                transform.localPosition = Vector3.Lerp(startPosition, endPosition, t);
                _timer += Time.deltaTime;
                yield return null;
            }

            onFinished?.Invoke(0);
            _timer = 0;
            yield return AnimateAsync(null);
        }
    }
}