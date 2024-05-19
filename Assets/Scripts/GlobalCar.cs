using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour
{
    public static int CarType; // 1 = yellow, 2 = blue, 3 = purple
    public GameObject ModeWindow;

    public void YellowCar(){
        CarType = 1;
        ModeWindow.SetActive(true);
    }

    public void BlueCar(){
        CarType = 2;
        ModeWindow.SetActive(true);
    }

    public void PurpleCar(){
        CarType = 3;
        ModeWindow.SetActive(true);
    }
}
