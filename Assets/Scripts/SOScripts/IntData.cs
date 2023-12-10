using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    // public UnityEvent disableEvent;
    public int value;
    public UnityEvent destroyEvent;
	public UnityEvent startEvent;


    public void SetValue(int num)
    {
        value = num;
    }

    public void SetValue(IntData obj)
    {
        value = obj.value;
    }

    public void UpdateValue(int num)
    {
        value += num;
    }

    public void CompareValue(IntData obj)
    {
        if (value <= obj.value)
        {
            
        }
        else
        {
            value = obj.value;
        }
    }

    private void Awake()
    {
        startEvent.Invoke();
    }

    private void onDestroy()
    {
        value = 0;
        destroyEvent.Invoke();
    }

    /*private void OnDisable()
    {
        disableEvent.Invoke();
    }*/
}