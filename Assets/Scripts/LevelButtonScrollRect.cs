using System;
using JetBrains.Annotations;
using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LevelButtonScrollRect : MonoBehaviour,IBeginDragHandler,IEndDragHandler
{
    private ScrollRect scrollRect;
    public float smoothing = 4;
    private float[] pageArray = new float[] {0, 0.3333f, 0.6666f, 1};
    public Toggle[] toggleArray;
    private float targetHorizontalPosition =0;
    private bool isDraging = false;
	// Use this for initialization
	void Start ()
	{
	    scrollRect = GetComponent<ScrollRect>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (isDraging == false)
	    {
	        scrollRect.horizontalNormalizedPosition = Mathf.Lerp(scrollRect.horizontalNormalizedPosition,
	            targetHorizontalPosition, Time.deltaTime*smoothing);
	    }
	}

    public void OnBeginDrag(PointerEventData eventData)
    {

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isDraging = false;
        float posX = scrollRect.horizontalNormalizedPosition;
        int index = 0;
        float offset = Mathf.Abs(pageArray[index] - posX);
        for (int i = 0; i < pageArray.Length; i++)
        {
            float offsetTemp = Mathf.Abs(pageArray[i] - posX);
            if (offsetTemp < offset)
            {
                index = i;
                offset = offsetTemp;
            }
        }
        targetHorizontalPosition = pageArray[index];
        toggleArray[index].isOn = true;
        //scrollRect.horizontalNormalizedPosition = pageArray[index];
    }

    public void MoveToPage1(bool isOn)
    {
        if (isOn)
        {
            targetHorizontalPosition = pageArray[0];
        }
    }
    public void MoveToPage2(bool isOn)
    {
        if (isOn)
        {
            targetHorizontalPosition = pageArray[1];
        }
    }
    public void MoveToPage3(bool isOn)
    {
        if (isOn)
        {
            targetHorizontalPosition = pageArray[2];
        }
    }
    public void MoveToPage4(bool isOn)
    {
        if (isOn)
        {
            targetHorizontalPosition = pageArray[3];
        }
    }
}
