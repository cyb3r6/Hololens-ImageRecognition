using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightHand : MonoBehaviour
{
    public Material highlightedMaterial;
    public Material unhighlightedMaterial;
    public GameObject highlightObject;
       
    void Start()
    {
        
    }

    public void Highlight()
    {
        Debug.Log("highlight");
        highlightObject.GetComponent<Renderer>().material = highlightedMaterial;
    }

    public void UnHighlight()
    {
        Debug.Log("unhighlight");
        highlightObject.GetComponent<Renderer>().material = unhighlightedMaterial;
    }
   
}
