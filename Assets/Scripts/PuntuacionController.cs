using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PuntuacionController : MonoBehaviour
{
    public static PuntuacionController instance;

    public GameObject pantallaPuntuaci�n;
    public int puntuaci�nTotal;
    public TextMeshProUGUI labelPuntos;
    public TextMeshProUGUI labelPuntosTotales;

    void Awake()
    {
        pantallaPuntuaci�n.SetActive(false);

        if (PuntuacionController.instance == null)
        {
            PuntuacionController.instance = this;

        }
        else
        {
            Destroy(this);
        }
    }

    void Update()
    {
        if (pantallaPuntuaci�n == true)
        {
            labelPuntos.text = "Puntuaci�n este nivel: " + PlayerPrefs.GetFloat("Puntos").ToString();
        }
    }

    public void NextLevel()
    {
        GameController.instance.nivel += 1;
        SceneManager.LoadScene(Random.Range(1, 2));
        Debug.Log(GameController.instance.nivel);
    }

    public void TryAgainLevel()
    {
        SceneManager.LoadScene(Random.Range(1, 2));
        Debug.Log(GameController.instance.nivel);
    }
}
