using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMode : MonoBehaviour
{
    public int ModeSelection;
    public GameObject RaceUI;
    public GameObject ScoreUI;
    public GameObject AICar1;
    public GameObject AICar2;
    public static int CurrentScore;
    public int InternalScore;
    public GameObject ScoreBoard;
    public GameObject ScoreItems;

    void Start()
    {
        ModeSelection = ModeScript.RaceMode;

        if(ModeSelection == 0)
            RaceUI.SetActive(true);

        if(ModeSelection == 1)
        {
            ScoreUI.SetActive(true);
            AICar1.SetActive(false);
            AICar2.SetActive(false);
            ScoreItems.SetActive(true);
        }
    }

    void Update(){
        ScoreBoard.GetComponent<TextMeshProUGUI>().text = "" + CurrentScore;
    }

}
