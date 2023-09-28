using UnityEngine;

namespace Project.Classes._230928
{
    public struct MyRealStruct
    {
        public double value;    
        public Vector3 position;

        public MyRealStruct(double value, Vector3 position, bool isActive)
        {
            this.value = value;     
            this.position = position;
        }
    }
}


