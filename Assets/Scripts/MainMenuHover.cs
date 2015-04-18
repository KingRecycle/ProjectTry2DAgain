using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainMenuHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Font defaultFont;
    public Font hoverFont;

    Text textComponent;

    void Awake()
    {
        textComponent = transform.GetChild(0).GetComponent<Text>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (hoverFont == null)
            return;

        textComponent.font = hoverFont;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (defaultFont == null)
            return;

        textComponent.font = defaultFont;
    }
}