using UnityEngine;
using UnityEngine.UI;

public class Resources : MonoBehaviour {
    public Text MeleeUI, RangedUI, SpecialUI;//UI elements to show how much resource you have
     public Text MeleePercent,RangedPercent,SpecialPercent;//UI Percentages by the bars
    int MeleeRes, RangedRes, SpecialRes;//Ints for the resources
   public Slider MeleeSlider, RangedSlider, SpecialSlider;//Slider bar objects
    bool MeleeOn, RangedOn, SpecialOn;//Bools for if production is on
    float MeleeProduction, RangedProduction, SpecialProduction;//Current production per tick
    float CurrentMelee, CurrentRanged, CurrentSpecial;//Overall total for that resouce
	// Use this for initialization
	void Start () {

        MeleeRes = 0;
        RangedRes = 0;
        SpecialRes = 0;
        MeleeOn = false;
        RangedOn = false;
        SpecialOn = false;
        MeleeProduction = 0;
        RangedProduction = 0;
        SpecialProduction = 0;
        CurrentMelee = 0;
        CurrentRanged = 0;
        CurrentSpecial= 0;
    }
	
	// Update is called once per frame
	void Update () {
        //Calcs total for balancing between bars
        float total = MeleeSlider.value + RangedSlider.value + SpecialSlider.value;
        int MeleeEndPercent = (int)(MeleeSlider.value / total * 100);
        int RangedEndPercent = (int)(RangedSlider.value / total * 100);
        int SpecialEndPercent = (int)(SpecialSlider.value / total * 100);

        //Sets the percentages by the bars
        MeleePercent.text = MeleeEndPercent.ToString() + "%";
        RangedPercent.text = RangedEndPercent.ToString() + "%";
        SpecialPercent.text = SpecialEndPercent.ToString() + "%";
        //if the bools are on then add the production to the current values
        if (MeleeOn)
        {
            CurrentMelee += MeleeProduction;
        }
        if (RangedOn)
        {
            CurrentRanged += RangedProduction;
        }
        if (SpecialOn)
        {
            CurrentSpecial += SpecialProduction;
        }

        //If the slider is above 0, then turn the productions on, and change the production values
        if (MeleeSlider.value >= .01)
        {
            MeleeProduction =(10 * MeleeEndPercent/100 * Time.deltaTime);
            MeleeOn = true;
        }
        else
        {
            MeleeOn = false;
        }
        if (RangedSlider.value >= .01)
        {
            RangedProduction = (10 * RangedEndPercent/100*Time.deltaTime);
            RangedOn = true;
        }
        else
        {
            RangedOn = false;
        }
        if (SpecialSlider.value >= .01)
        {
            SpecialProduction = (10 * SpecialEndPercent/100 * Time.deltaTime);
            SpecialOn = true;
        }
        else
        {
            SpecialOn = false;
        }

        //Sets the Top Bar UI values 
        MeleeUI.text = "Melee: " + CurrentMelee.ToString("F0");
        RangedUI.text = "Ranged: " + CurrentRanged.ToString("F0") ;
        SpecialUI.text = "Special: " + CurrentSpecial.ToString("F0") ;
    }
}
