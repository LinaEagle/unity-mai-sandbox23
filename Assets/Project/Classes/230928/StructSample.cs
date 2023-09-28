using UnityEngine;

namespace Project.Classes._230928
{
    public class StructSample : MonoBehaviour
    {
        private MyRealStruct _realStruct = new MyRealStruct(10, Vector3.up, true);
        private MyPseudoStruct _myPseudoStruct;
    
        private void Start()
        {
            _myPseudoStruct = new MyPseudoStruct()
            {
                message = "Message",
                value = 15,
                Transform = transform
            };
        
            Debug.Log($"Before: real struct - value - {_realStruct.value}");
            Debug.Log($"After: pseudo struct - value - {_myPseudoStruct.value}, message - {_myPseudoStruct.message}, position - {_myPseudoStruct.Transform.position}");
        
            DoSomething(_realStruct, _myPseudoStruct);
            DoSomethingWithBoxing(ref _realStruct, ref _myPseudoStruct);
        }

        private void DoSomething(MyRealStruct realStruct, MyPseudoStruct pseudoStruct)
        {
            realStruct.value = 0;
        
            pseudoStruct.value = 0;
            pseudoStruct.message = "No message";
            pseudoStruct.Transform.position = Vector3.one;
        
            Debug.Log($"After: real struct - value - {_realStruct.value}");
            Debug.Log($"After: pseudo struct - value - {_myPseudoStruct.value}, message - {_myPseudoStruct.message}, position - {_myPseudoStruct.Transform.position}");
        }
    
        private void DoSomethingWithBoxing(ref MyRealStruct realStruct, ref MyPseudoStruct pseudoStruct)
        {
            realStruct.value = 0;
        
            pseudoStruct.value = 0;
            pseudoStruct.message = "No message";
            pseudoStruct.Transform.position = Vector3.one;
        
            Debug.Log($"After boxing: real struct - value - {_realStruct.value}");
            Debug.Log($"After boxing: pseudo struct - value - {_myPseudoStruct.value}, message - {_myPseudoStruct.message}, position - {_myPseudoStruct.Transform.position}");
        }
    }
}
