using UnityEngine;

public class CarControlActive : MonoBehaviour
{
    public GameObject CarControl;
    public GameObject DreamCar01;
    public GameObject DreamCar02;
    void Start()
    {
        CarControl.GetComponent<CarController>().enabled = true;
        // Debug.Log(DreamCar01.GetComponent<CarAI>());
        DreamCar01.GetComponent<CarAI>().enabled = true;
        DreamCar02.GetComponent<CarAI>().enabled = true;
    }
}
