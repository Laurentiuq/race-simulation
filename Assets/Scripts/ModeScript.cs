using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeScript : MonoBehaviour
{
    public static int RaceMode; // 0=Race, 1=Score, 2=Time
    public GameObject TrackPanel;

    public void ScoreMode(){
        RaceMode = 1;
        TrackPanel.SetActive(true);
    }

    public void TimeMode(){
        RaceMode = 2;
        TrackPanel.SetActive(true);
    }

    public void RaceModeSelect(){
        RaceMode = 0;
        TrackPanel.SetActive(true);
    }
}
