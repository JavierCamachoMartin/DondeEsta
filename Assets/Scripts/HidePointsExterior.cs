using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePointsExterior : MonoBehaviour
{
    public static HidePointsExterior instance;

    public GameObject[] hidePoints;
    public GameObject selectedHidePoint;

    public GameObject playerPrefab;

    private GameObject player;

    void Awake()
    {
        if (HidePointsExterior.instance == null)
        {
            HidePointsExterior.instance = this;
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
