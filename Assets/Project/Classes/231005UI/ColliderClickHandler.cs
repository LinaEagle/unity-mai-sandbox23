using System;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Project.Classes._231005UI
{
    [RequireComponent(typeof(Collider))]
    public class ColliderClickHandler : MonoBehaviour, IPointerClickHandler
    {
        public UnityEvent OnClick;
        private void OnValidate()
        {
            Assert.IsNotNull(FindObjectOfType<EventSystem>(), $"{GetType()} needs EventSystem component on the scene!");
            Assert.IsNotNull(Camera.main.GetComponent<PhysicsRaycaster>(), $"{GetType()} needs Camera to have PhysicsRaycaster component!");
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            Debug.Log($"Clicked on {gameObject.name}");
            OnClick?.Invoke();
        }
    }
}
