using UnityEngine;

namespace Project.Homework.HW230914
{
    public class ObjectB : MonoBehaviour
    {
        [SerializeField] protected float speed = 1;
    
        private void Update()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                // depend on scale ratio
                transform.localScale += speed * Time.deltaTime * Vector3.one;
            }
        }
    }
}