using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceFinish : MonoBehaviour
{
    public GameObject MyCar;
    public GameObject FinishCam;
    public GameObject ViewModes;
    public GameObject LevelMusic;
    public GameObject CompleteTrig;
    private bool getRewardOnce = true;

    void OnTriggerEnter()
    {
        if(TimeMode.isTimeMode)
        {
            // race time mode
        }
        else{
            MyCar.SetActive(false);
            CompleteTrig.SetActive(false);
            CarController.stopMultiplier = 0;
            MyCar.GetComponent<CarController>().enabled = false;
            MyCar.SetActive(true);
            FinishCam.SetActive(true);
            LevelMusic.SetActive(false);
            ViewModes.SetActive(false);

            RewardRaceEnd();

        }

    }

    void RewardRaceEnd(){

        if(getRewardOnce)
        {
            GlobalCash.TotalCash += 100;
            getRewardOnce = false;
        }
        PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCash);
    }
   
}
