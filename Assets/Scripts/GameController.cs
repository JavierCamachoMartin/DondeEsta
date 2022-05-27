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

}
