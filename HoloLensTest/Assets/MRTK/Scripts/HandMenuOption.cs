using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HandMenuOption : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshPro title;
    public GameObject menu;
    public string section;
    void Start()
    {
        
    }

    public void showMenu()
    {
        menu.SetActive(true);
        title.text = section;
    }
}
