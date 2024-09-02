using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class foruibuttons : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject hoverbutton;

    public void OnPointerEnter(PointerEventData eventData)
    {
        hoverbutton.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        hoverbutton.SetActive(false);
    }
    // Start is called before the first frame update

}
