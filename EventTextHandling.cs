// --------------- BY THEP200 ------------------
// add tag <link></link> for the text that your want to be handle its.
// add this scripts to the object that contains the TMP_Text.


using System.Collections.Generic;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class EventTextHandling : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    public Camera CameraCanvas;

    [SerializeField]
    public GameObject SceneEffect;

    [HideInInspector]
    TMP_Text m_TmpText;

    // add more somethings here

    // Start is called before the first frame update
    void Start()
    {
        m_TmpText = this.gameObject.GetComponent<TMP_Text>();
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        int indexOfLink = TMP_TextUtilities.FindIntersectingLink(m_TmpText, Input.mousePosition, CameraCanvas);

        // by index of the link in the text start 0
        switch(indexOfLink != -1)
        {
            case true:
                // for your code

                SceneEffect.SetActive(true);
                break;
            case false:
                // for your code

                Debug.Log("No link was clicked.");
                break;
        }
    }
}
