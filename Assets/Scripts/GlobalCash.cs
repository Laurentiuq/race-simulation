using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{
    public int CashValue;
    public static int TotalCash;
    public GameObject CashDisplay;

    void Start()
    {
        TotalCash = PlayerPrefs.GetInt("SavedCash");
    }

    void Update()
    {
        CashValue = TotalCash;  

        CashDisplay.GetComponent<TextMeshProUGUI>().text = "Cash $" + CashValue;

    }
}
