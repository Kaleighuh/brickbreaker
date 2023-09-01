using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Globalization;

public class TextLabelBehavour : MonoBehaviour
{
    public Text label;
    public UnityEvent startEvent;
    public UnityEvent onClick;

    private void Start()
    {
        label = GetComponent<Text>();
        startEvent.Invoke();
    }

    public void UpdateLabel(FloatData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }

    public void UpdateLabel(IntData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }
    
    private void onClickEnter()
    {
        onClick.Invoke();
    }
}