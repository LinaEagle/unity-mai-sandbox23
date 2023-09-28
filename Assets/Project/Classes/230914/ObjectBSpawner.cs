using UnityEngine;

namespace Project.Classes._230914
{
    public class ObjectBSpawner : MonoBehaviour
    {
        public ObjectB prefab;
        public Vector3 startPosition = new Vector3(10, 10, 10);
        private ObjectB _objectB;

        public ObjectB GetObjectB() => _objectB;
        
        private void Start()
        {
            _objectB = Instantiate(prefab, startPosition, Quaternion.identity);
        }
    }
}