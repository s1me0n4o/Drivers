using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChousedCarCol : MonoBehaviour
{
    public GameObject YellowCar;
    public GameObject BlueCar;
    public GameObject DefaultCar;
    public int SelectedColor;

    // Start is called before the first frame update
    void Start()
    {
        SelectedColor = SelectACar.CarType;
        
        if (SelectedColor == 1)
        {
            YellowCar.SetActive(true);
            DefaultCar.SetActive(false);
        }
        else if (SelectedColor == 2)
        {
            BlueCar.SetActive(true);
            DefaultCar.SetActive(false);
        }
        else
        {
            DefaultCar.SetActive(true);
            YellowCar.SetActive(false);
            BlueCar.SetActive(false);
        }
    }

 
}
