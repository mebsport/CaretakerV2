using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour
{

    string GooglePlay_ID = "3330924";
    bool TestMode = true;

    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(GooglePlay_ID, TestMode);
    }

    public void DisplayInterstitialAD()
    {
        Advertisement.Show();
    }
}
