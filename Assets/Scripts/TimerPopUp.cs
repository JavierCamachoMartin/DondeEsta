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
        searchTimer = searchSeg;

        if (TimerPopUp.instance == null)
        {
            TimerPopUp.instance = this;
            DontDestroyOnLoad(this.gameObject);
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
            int tempSeg = Mathf.FloorToInt(searchTimer % 60);
            labelSearchTimer.text = tempSeg.ToString();
        }
    }
}
