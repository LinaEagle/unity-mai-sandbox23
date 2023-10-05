using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Project.Classes._231005UI
{
    public class ActionSample : MonoBehaviour
    {
        public Button button;
        public delegate void CustomAction(int value);
        public CustomAction OnCustomDone;

        public Action OnDone;
        public UnityAction OnUnityDone;

        public event Action OnDoneEvent;
        public UnityEvent OnFinished;
        private Camera _camera;

        private void Start()
        {
            _camera = Camera.main;
            var distance = Vector3.Distance(transform.position, _camera.transform.position);
            var near = 1;
            var far = 15; // 
        }
    }
}