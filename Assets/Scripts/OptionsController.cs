using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    public GameObject optionsWindow;
    public GameObject blackOutPanel;
    public InkTest inkOptions;

    public Font openDyslexic;
    public Font openDyslexicMono;

    public Dropdown fontSizeDropdown;

    public Font arial;

    

    public void ToggleOptions()
    { 
        optionsWindow.SetActive(!optionsWindow.activeInHierarchy);
        blackOutPanel.SetActive(!blackOutPanel.activeInHierarchy);
    }

    public void SetFontSize(Dropdown dropdown)
    {
        //Debug.Log("Set Font Size Index: " + dropdown.value);
        //Debug.Log("InkOptions User Font: " + inkOptions.userFont);
        switch (dropdown.value)
        {
            case 0:
                if (inkOptions.userFont == arial)
                {
                    inkOptions.storyText.fontSize = 16;
                    inkOptions.userFontSize = 16;
                }
                else
                {
                    inkOptions.storyText.fontSize = 6;
                    inkOptions.userFontSize = 6;
                }
                break;
            case 1:
                if (inkOptions.userFont == arial)
                {
                    inkOptions.storyText.fontSize = 18;
                    inkOptions.userFontSize = 18;
                }
                else
                {
                    inkOptions.storyText.fontSize = 8;
                    inkOptions.userFontSize = 8;
                }
                break;
            case 2:
                if (inkOptions.userFont == arial)
                {
                    inkOptions.storyText.fontSize = 20;
                    inkOptions.userFontSize = 20;
                }
                else
                {
                    inkOptions.storyText.fontSize = 10;
                    inkOptions.userFontSize = 10;
                }
                break;
            case 3:
                if (inkOptions.userFont == arial)
                {
                    inkOptions.storyText.fontSize = 24;
                    inkOptions.userFontSize = 24;
                }
                else
                {
                    inkOptions.storyText.fontSize = 14;
                    inkOptions.userFontSize = 14;
                }
                break;
            case 4:
                if (inkOptions.userFont == arial)
                {
                    inkOptions.storyText.fontSize = 28;
                    inkOptions.userFontSize = 28;
                }
                else
                {
                    inkOptions.storyText.fontSize = 18;
                    inkOptions.userFontSize = 18;
                }
                break;
            case 5:
                if (inkOptions.userFont == arial)
                {
                    inkOptions.storyText.fontSize = 32;
                    inkOptions.userFontSize = 32;
                }
                else
                {
                    inkOptions.storyText.fontSize = 22;
                    inkOptions.userFontSize = 22;
                }
                break;
            case 6:

                if (inkOptions.userFont == arial)
                {
                    inkOptions.storyText.fontSize = 36;
                    inkOptions.userFontSize = 36;
                }
                else
                {
                    inkOptions.storyText.fontSize = 26;
                    inkOptions.userFontSize = 26;
                }

                break;
           

        }
    }
    

    public void SetFontFamily(Dropdown dropdown)
    {

        //Debug.Log("Set Font Family Index: " + dropdown.value);
        switch (dropdown.value)
        {
            case 0:
                inkOptions.storyText.font = arial;
                inkOptions.userFont = arial;
                SetFontSize(fontSizeDropdown);
                break;
            case 1:
                inkOptions.storyText.font = openDyslexic;
                inkOptions.userFont = openDyslexic;
                SetFontSize(fontSizeDropdown);
                break;
            /*case 2:
                inkOptions.storyText.font = openDyslexicMono;
                inkOptions.userFont = openDyslexicMono;
                SetFontSize(fontSizeDropdown);
                break;*/
        }

    }
}
