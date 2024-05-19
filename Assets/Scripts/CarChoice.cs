using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    public GameObject YellowBody;
    public GameObject BlueBody;

    public GameObject PurpleBody;
    public int CarImport;

    void Start()
    {   
        CarImport = GlobalCar.CarType;
        
        switch(CarImport){
            case 1: YellowBody.SetActive(true);
                    break;
            case 2: BlueBody.SetActive(true);
                    break;
            case 3: PurpleBody.SetActive(true);
                    break;
            default: PurpleBody.SetActive(true);
                    break;
        }
    }

}
