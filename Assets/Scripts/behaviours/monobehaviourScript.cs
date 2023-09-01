using UnityEngine;
using UnityEngine.Events;

public class MonobehaviourScript : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent;
    public UnityEvent onClick;
    public UnityEvent destroyEvent;

    private void Awake()
    {
        awakeEvent.Invoke();
    }

    private void Start()
    {
        startEvent.Invoke();
    }

    private void Disable()
    {
        disableEvent.Invoke();
    }
    void OnMouseDown()
    {
        onClick.Invoke();
    }
    
    private void OnDestroy()
    {
        destroyEvent.Invoke();
    }
    
}