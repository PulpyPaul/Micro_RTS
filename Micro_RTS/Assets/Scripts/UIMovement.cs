using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMovement : MonoBehaviour {

    public GameObject panel;
    /*
    public float left;
    public float right;
    public float top;
    public float bottom;
    */
    public Button b1;

    // Use this for initialization
    void Start () {
        /*
        left = panel.GetComponent<RectTransform>().offsetMin.x;
        right = -panel.GetComponent<RectTransform>().offsetMax.x;
        top = -panel.GetComponent<RectTransform>().offsetMax.y;
        bottom = panel.GetComponent<RectTransform>().offsetMin.y;
        */
        panel.SetActive(false);
        b1 = this.gameObject.GetComponent<Button>();

        b1.onClick.AddListener(ShowMenu);
    }

    void ShowMenu()
    {
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the button!");
        /*
        right = right + left;
        left = 0.0f;
        top = top + bottom;
        bottom = 0.0f;
        panel.GetComponent<RectTransform>().offsetMin = new Vector2(left, bottom);
        panel.GetComponent<RectTransform>().offsetMax = new Vector2(-right, -top);
        */
        panel.SetActive(true);
    }

    // Update is called once per frame
    void Update () {
    }
}
