using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlockables : MonoBehaviour
{   
    public GameObject FakePurpleCar;
    public GameObject UpdateCashText;
    public int CashValue;
    void Start()
    {
        
    }
    void Update()
    {
        CashValue = GlobalCash.TotalCash;
        
        if(CashValue >= 100)
            FakePurpleCar.GetComponent<Button>().interactable = true;
    }

    public void BuyPurpleCar(){
        FakePurpleCar.SetActive(false);
        CashValue -= 100;
        GlobalCash.TotalCash -= 100;
        PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCash);
    }
}
