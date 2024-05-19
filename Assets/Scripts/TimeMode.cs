using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeMode : MonoBehaviour
{
    public int ModeSelection;
    public GameObject RaceUI;
    public GameObject AICar1;
    public GameObject AICar2;

    public static bool isTimeMode = false;
    void Start()
    {
        ModeSelection = ModeScript.RaceMode;

        if(ModeSelection == 2)
        {
                RaceUI.SetActive(true);
                AICar1.SetActive(false);
                AICar2.SetActive(false);
                isTimeMode = true;
        }
    }

}
