using UnityEngine;

namespace Project.Classes._230928
{
    public struct MyPseudoStruct
    {
        public string message;
        public int value;
        public Transform Transform;

        public override string ToString()
        {
            return message;
        }
    }
}