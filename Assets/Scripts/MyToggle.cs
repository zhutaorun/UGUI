using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MyToggle : MonoBehaviour
{

    public GameObject isOnGameObject;
    public GameObject isOffGameObject;

    private Toggle toggle;
	// Use this for initialization
	void Start ()
	{
	    toggle = GetComponent<Toggle>();
        OnValueChange(toggle.isOn);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnValueChange(bool isOn)
    {
        isOnGameObject.SetActive(isOn);
        isOffGameObject.SetActive(!isOn);
    }
}
