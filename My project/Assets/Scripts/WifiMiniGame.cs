using System.Reflection;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.EventSystems;

public class WifiMiniGame : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public PlayerMiniGame playerMiniGame; // to see if we are currently playing the game
    public Canvas canvas;
    CanvasGroup canvasGroup;

    public bool set = false;


    public void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>(); // for the scale factor
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!set)
        {
        RectTransform rect = GetComponent<RectTransform>();
        rect.anchoredPosition += eventData.delta / canvas.scaleFactor;
        canvasGroup.blocksRaycasts = false;
        }

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if(!set)
        {
        canvasGroup.blocksRaycasts = true; // unity only tracks the currently selected object
        }
    }

}
