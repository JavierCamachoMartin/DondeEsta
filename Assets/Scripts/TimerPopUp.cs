using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerPopUp : MonoBehaviour
{
    public static TimerPopUp instance;

    public GameObject wantedScreen;
    public GameObject timerScreen;
    public TextMeshProUGUI labelSearchTimer;
    public int searchSeg;
    private bool isWantedScreen;
    public float searchTimer;

    void Awake()
    {
        timerScreen.SetActive(false);

        if (TimerPopUp.instance == null)
        {
            TimerPopUp.instance = this;
            
        }
        else
        {
            Destroy(this);
        }
    }

    void Update()
    {
        if (WantedScreen.instance.timer <= 0)
        {
            timerScreen.SetActive(true);
            searchTimer += Time.deltaTime;
            labelSearchTimer.text = searchTimer.ToString("f0");
        }

        if (WantedScreen.instance.timer >= 0)
        {
            timerScreen.SetActive(false);
            searchTimer = 0;
            labelSearchTimer.text = searchTimer.ToString("f0");
        }
    }
}
