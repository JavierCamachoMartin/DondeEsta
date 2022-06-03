using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PuntuacionController : MonoBehaviour
{
    public static PuntuacionController instance;

    public GameObject pantallaPuntuación;
    public int puntuaciónTotal;
    public TextMeshProUGUI labelPuntos;
    public TextMeshProUGUI labelPuntosTotales;

    void Awake()
    {
        pantallaPuntuación.SetActive(false);

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
        if (pantallaPuntuación == true)
        {
            labelPuntos.text = "Puntuación este nivel: " + PlayerPrefs.GetFloat("Puntos").ToString();
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
