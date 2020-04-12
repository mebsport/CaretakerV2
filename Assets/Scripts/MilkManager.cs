using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MilkManager : MonoBehaviour
{
    public int milkQuantity;
    public Text milkAmmountText;


    // Update is called once per frame
    void Update()
    {
        milkQuantity = PlayerPrefs.GetInt("MilkAmmount");
        milkAmmountText.text = milkQuantity.ToString();
    }
}
