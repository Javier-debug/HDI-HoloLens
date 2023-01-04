using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Microsoft.MixedReality.Toolkit.UI;

public class HandMenuOption : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshPro title;
    public GameObject menu;
    public string section;
    public string iconName;
    public string[] buttonTitle;
    public ButtonConfigHelper[] buttons;
    private int i = 0;

    void Start()
    {
        
    }

    public void showMenu()
    {
        menu.SetActive(true);
        title.text = section;
        foreach(ButtonConfigHelper button in buttons)
        {
            button.SetQuadIconByName(iconName);
            button.MainLabelText = buttonTitle[i];
            i++;
        }
        i = 0;
    }
}
