using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerPopUp : MonoBehaviour
{
    public static TimerPopUp instance;

    void Awake()
    {
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
}
