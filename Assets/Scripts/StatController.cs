using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatController : MonoBehaviour
{
    public Slider energySlider;
    public Text energySliderLabel;

    public Slider comfortSlider;
    public Text comfortSliderLabel;

    public Slider hungerSlider;
    public Text hungerSliderLabel;

    public Slider bladderSlider;
    public Text bladderSliderLabel;

    public Slider hygieneSlider;
    public Text hygieneSliderLabel;


    public void UpdateEnergyStat(int energy)
    {        
        energySlider.value = energy;
        energySliderLabel.text = "Energy: " + energy;
    }

    public void UpdateComfortStat(int comfort)
    {
        comfortSlider.value = comfort;
        comfortSliderLabel.text = "Comfort: " + comfort;
    }

    public void UpdateHungerStat(int hunger)
    {
        hungerSlider.value = hunger;
        hungerSliderLabel.text = "Hunger: " + hunger;
    }

    public void UpdateBladderStat(int bladder)
    {
        bladderSlider.value = bladder;
        bladderSliderLabel.text = "Bladder: " + bladder;
    }

    public void UpdateHygieneStat(int hygiene)
    {
        hygieneSlider.value = hygiene;
        hygieneSliderLabel.text = "Hygiene: " + hygiene;
    }
}
