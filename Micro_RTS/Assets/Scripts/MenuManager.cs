using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuManager : MonoBehaviour {

    public GameObject cmdPanel;
    public GameObject resourcePanel;
    public GameObject unitPanel;
    public GameObject specialPanel;

    public Button btn1;
    public Button btn2;
    public Button btn3;

	//public Toggle top;
//	public Toggle mid;
//	public Toggle bot;

    // Use this for initialization
    void Start () {
        cmdPanel = GameObject.Find("CMD_Panel");
        resourcePanel = GameObject.Find("Resource_Panel");
        unitPanel = GameObject.Find("Unit_Panel");
        specialPanel = GameObject.Find("Special_Panel");

        btn1 = GameObject.Find("Material_Production").gameObject.GetComponent<Button>();

        btn1.onClick.AddListener(() => ShowMenu(1));

        btn2 = GameObject.Find("Unit_Production").gameObject.GetComponent<Button>();

        btn2.onClick.AddListener(() => ShowMenu(2));

        btn3 = GameObject.Find("Upgrade").gameObject.GetComponent<Button>();

        btn3.onClick.AddListener(() => ShowMenu(3));

        cmdPanel.SetActive(true);
        resourcePanel.SetActive(false);
        unitPanel.SetActive(false);
        specialPanel.SetActive(false);

    }

    void ShowMenu(int menuNum)
    {
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the button!");

        cmdPanel.SetActive(false);
        resourcePanel.SetActive(false);
        unitPanel.SetActive(false);
        specialPanel.SetActive(false);

        switch (menuNum)
        {

            case 1:
                resourcePanel.SetActive(true);
                break;
            case 2:
                unitPanel.SetActive(true);
                break;
            case 3:
                specialPanel.SetActive(true);
                break;
        }
        
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                cmdPanel.SetActive(true);
                resourcePanel.SetActive(false);
                unitPanel.SetActive(false);
                specialPanel.SetActive(false);
            }

            if(!EventSystem.current.IsPointerOverGameObject())
            {
                cmdPanel.SetActive(true);
                resourcePanel.SetActive(false);
                unitPanel.SetActive(false);
                specialPanel.SetActive(false);
            }
        }
    }
}
