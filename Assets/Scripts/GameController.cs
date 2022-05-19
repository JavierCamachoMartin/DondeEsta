using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    public GameObject[] buscados;
    int buscador;

    public GameObject persona;

    void Start()
    {
        if (GameController.instance == null)
        {
            GameController.instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public GameObject RandomPersonaje()
    {
        buscador = Random.Range(0, buscados.Length);
        return Instantiate(buscados[buscador]);
    }
}
