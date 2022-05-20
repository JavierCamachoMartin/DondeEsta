using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePointsInterior : MonoBehaviour
{
    public static HidePointsInterior instance;

    public GameObject[] hidePoints;
    public GameObject selectedHidePoint;

    public GameObject playerPrefab;

    private GameObject player;

    void Awake()
    {
        if (HidePointsInterior.instance == null)
        {
            HidePointsInterior.instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        RandomEscondite();
    }

    public void RandomEscondite()
    {
        int random = Random.Range(0, hidePoints.Length);
        selectedHidePoint = hidePoints[random];
        player = Instantiate(playerPrefab, selectedHidePoint.transform.position, selectedHidePoint.transform.localRotation);
    }
}
