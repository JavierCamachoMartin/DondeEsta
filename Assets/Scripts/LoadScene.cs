using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void CargarEscena()
    {
        SceneManager.LoadScene(Random.Range(1, 3));
    }

    public void CerrarJuego()
    {
        Application.Quit();
    }
}
