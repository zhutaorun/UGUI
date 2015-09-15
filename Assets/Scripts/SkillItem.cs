using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SkillItem : MonoBehaviour {

    public float coldTime = 2;
    public KeyCode keycode;
    private float timer = 0;
    private Image filedImage;
    private bool isStartTime = false;
	// Use this for initialization
	void Start () {
        filedImage = transform.Find("FiledImage").GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(keycode)) {
            isStartTime = true;
        }
        if (isStartTime) {
            timer += Time.deltaTime;
            filedImage.fillAmount = (coldTime - timer) / coldTime;
            if (timer >= coldTime) {
                filedImage.fillAmount = 0;
                timer = 0;
                isStartTime = false;
            }
        }
	}

    public void OnClick() {
        isStartTime = true;
    }
}
