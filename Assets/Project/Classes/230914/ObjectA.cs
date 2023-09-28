using System;
using UnityEngine;

namespace Project.Classes._230914
{
    public class ObjectA : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float speed = 10f;
        [SerializeField] private float distanceThreshold = 0.1f;

        private void Update()
        {
            Move();
            CheckDistanceToSelfDestroy();
        }
        
        private void Move()
        {
            var direction = Vector3.zero;
            direction += Convert.ToInt32(Input.GetKey(KeyCode.W)) * Vector3.forward;
            direction += Convert.ToInt32(Input.GetKey(KeyCode.A)) * Vector3.left;
            direction += Convert.ToInt32(Input.GetKey(KeyCode.S)) * Vector3.back;
            direction += Convert.ToInt32(Input.GetKey(KeyCode.D)) * Vector3.right;
            ;
            transform.position += speed * Time.deltaTime * direction;
        }
        
        private void CheckDistanceToSelfDestroy()
        {
            var other = FindObjectOfType<ObjectB>();
            if (other is not null)
            {
                var distance = Vector3.Distance(transform.position, other.transform.position);
                if (distance < distanceThreshold)
                {
                    Debug.Log("Destroy");
                    Destroy(gameObject);
                }
            }
        }
    }
}