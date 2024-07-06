using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ToggleGameObject : MonoBehaviour
{
    public GameObject[] carList;
    int currentCarNumber = -1;


    public void Toggle(int carNumber)
    {
        if (currentCarNumber != carNumber)
        {
            if (currentCarNumber >= 0)
            {
                carList[currentCarNumber].SetActive(!gameObject.activeInHierarchy);
            }
            carList[carNumber].SetActive(gameObject.activeInHierarchy);
            currentCarNumber = carNumber;
        }


    }


}
