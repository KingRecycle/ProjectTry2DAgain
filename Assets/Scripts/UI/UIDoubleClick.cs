using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class UIDoubleClick : MonoBehaviour, IPointerClickHandler
{
    public bool ignoreRightClick = true;

    public UnityEvent OnDoubleClick;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.clickCount > 1)
        {
            OnDoubleClick.Invoke();
        }
    }
}