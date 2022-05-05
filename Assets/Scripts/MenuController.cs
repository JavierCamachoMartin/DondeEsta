using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuController : MonoBehaviour
{
    public GameObject initialScreen;
    public GameObject wantedScreen;
    public TextMeshProUGUI labelTimer;

    public bool isWantedScreen = false;
    public float wantedTimer = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisableWantedScreen();
    }

    public void EnableWantedScreen()
    {
        initialScreen.SetActive(false);
        wantedScreen.SetActive(true);
        isWantedScreen = true;
    }

    public void DisableWantedScreen()
    {
        if (isWantedScreen == true)
        {
            wantedTimer -= Time.deltaTime;
            labelTimer.text = wantedTimer.ToString();
            if (wantedTimer <= 0)
            {
                wantedTimer = 0f;
                wantedScreen.SetActive(false);
                isWantedScreen = false;
            }
        }
    }
}
