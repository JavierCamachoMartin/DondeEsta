using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    public GameObject[] personajes;
    public int iChar;

    public bool isPlaying;
    public int nivel = 1;

    void Awake()
    {
        if (GameController.instance == null)
        {
            GameController.instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    public GameObject RandomPersonaje() //GameObject para que devuelva un GameObject
    {
        iChar = Random.Range(0, personajes.Length);
        return Instantiate(personajes[iChar]); //El instantiate es para crear un personaje nuevo basado en la línea de arriba //Ponemos corchete porque es una Array
    }

    public GameObject RandomPersonas()
    {
        int num = Random.Range(0, personajes.Length);

        while (num == iChar)
        {
            num = Random.Range(0, personajes.Length);
        }
        return Instantiate(personajes[num]);
    }

    public void RellenarNivel()
    {
        //Crea el buscado en el nivel
        GameObject buscado = Instantiate(personajes[iChar]);
        GameObject escondite = HidePoints.instance.RandomHidePoints();
        buscado.transform.parent = escondite.transform;
        buscado.transform.localPosition = Vector3.zero;
        buscado.transform.localScale = Vector3.one;
        buscado.transform.LookAt(Camera.main.transform);

        for (int i = 0; i < (nivel * 5 - 1); i++)
        {
            GameObject personas = RandomPersonas();
            GameObject escondites = HidePoints.instance.RandomHidePoints();
            personas.transform.parent = escondites.transform;
            personas.transform.localPosition = Vector3.zero;
            personas.transform.localScale = Vector3.one;
            personas.transform.LookAt(Camera.main.transform);
        }
    }
}
