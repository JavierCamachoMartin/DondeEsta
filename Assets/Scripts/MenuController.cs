using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject initialScreen;
    public GameObject wantedScreen;
    public TextMeshProUGUI labelTimer;

    public int seg;
    private float timer;
    private bool isWantedScreen;

    private void Awake()
    {
        timer = seg;
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
            timer -= Time.deltaTime;
            
            if (timer <= 0)
            {
                timer = 0f;
                wantedScreen.SetActive(false);
                isWantedScreen = false;
            }

            int tempSeg = Mathf.FloorToInt(timer % 60);
            labelTimer.text = tempSeg.ToString();
        }
    }
}
