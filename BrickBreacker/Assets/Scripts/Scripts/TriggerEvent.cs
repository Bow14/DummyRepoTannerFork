using UnityEngine;
using UnityEngine.Events;

namespace Scripts
{
    [RequireComponent(typeof(Collider))]
    public class TriggerEvent : MonoBehaviour
    {
        public UnityEvent triggerEnterEvent, triggerColorEvent, clickEvent, playerEvent;
        public LayerMask coin;
        public LayerMask player;
        private Collider colliderObj;

        private void Start()
        {
            colliderObj = GetComponent<Collider>();
            colliderObj.isTrigger = true;
        }

        private void OnTriggerEnter(Collider col)
        {
            if (col.CompareTag("Player"))
            {
                playerEvent.Invoke();
            }
            if (coin == LayerMask.NameToLayer("Coin"))
            {
                Debug.Log("You have entered");
            
            }
            if (LayerMask.NameToLayer("Player") == player)
            {
            
            }
            triggerEnterEvent.Invoke();
            triggerColorEvent.Invoke();
            
        }

        void OnButtonClick()
        {
            clickEvent.Invoke();
        }
    }
}
