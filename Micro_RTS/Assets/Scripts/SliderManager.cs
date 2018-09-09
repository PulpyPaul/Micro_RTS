using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour {

    // Use this for initialization
    public Slider slider1;
    public Slider slider2;
    public Slider slider3;
    public Text percentA;
    public Text percentB;
    public Text percentC;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CalculatePercentage();
	}

    void CalculatePercentage()
    {
        float total = slider1.value+ slider2.value + slider3.value;
        Debug.Log(total);


        int s1 = (int)(slider1.value/total * 100);
        int s2 = (int)(slider2.value/total *100);
        int s3 = (int)(slider3.value/total *100);

        Debug.Log(s1);



        percentA.text = s1.ToString()+"%";
        percentB.text = s2.ToString() + "%";
        percentC.text = s3.ToString() + "%";
    }
}
