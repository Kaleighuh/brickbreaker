using UnityEngine;
using UnityEngine.Events;
public class triggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
    
}