using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePoints : MonoBehaviour
{
    public static HidePoints instance;

    public GameObject[] hidePoints;
    public GameObject selectedHidePoint;

    public GameObject playerPrefab;

    private GameObject personaje;

    void Awake()
    {
        if (HidePoints.instance == null)
        {
            HidePoints.instance = this;
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
        personaje = Instantiate(GameController.instance.personajes[GameController.instance.iChar], selectedHidePoint.transform.position, selectedHidePoint.transform.localRotation);
        personaje.transform.parent = selectedHidePoint.transform;
        personaje.transform.localScale = Vector3.one * 3;
        personaje.transform.LookAt(Camera.main.transform);
    }
}
