using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/*
TODO
lock the player in place and camera while doing the taks
add a message that displays when the task is done
lock players out of the task once it is done


*/

public class SnappingBehaviour : MonoBehaviour, IDropHandler
{
    
    public WifiMiniGame wmg; // so we can lock it's position once set
    public RectTransform otherImage; // image component of the other image
    private RectTransform rect; // position of the current image
    public UnityEngine.UI.Image img; // current image component, to edit the transparent data
 
    public void Awake()
    {
        rect = GetComponent<RectTransform>(); // backgrund image pos
    }

    public void Start()
    {
        img.alphaHitTestMinimumThreshold = 0.1f; // ensures we cannot click the transparent parts of the image
    }

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null && eventData.pointerDrag.GetComponent<RectTransform>().tag == tag)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            // TODO lock the position
            wmg.set = true;
        }
    }


}
