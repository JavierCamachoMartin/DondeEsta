using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    public GameObject[] buscados;
    int buscador;

    public GameObject persona;

    public Scene[] escenasJuego;
    public GameObject initialScreen;
    public GameObject wantedScreen;
    public GameObject timerScreen;
    public TextMeshProUGUI labelTimer;
    public TextMeshProUGUI labelSearchTimer;

    public int seg;
    public int searchSeg;
    private float timer;
    private bool isWantedScreen;
    public float searchTimer;

    void Awake()
    {
        timer = seg;
        searchTimer = searchSeg;
        timerScreen.SetActive(false);
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
        DisableWantedScreen();

        if (isWantedScreen == false)
        {
            searchTimer += Time.deltaTime;
            int tempSeg = Mathf.FloorToInt(searchTimer % 60);
            labelSearchTimer.text = tempSeg.ToString();
        }
    }

    public void EnableWantedScreen()
    {
        initialScreen.SetActive(false);
        wantedScreen.SetActive(true);
        isWantedScreen = true;
    }

    public void DisableWantedScreen()
    {
        if (isWantedScreen == true)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                timer = 0f;
                wantedScreen.SetActive(false);
                isWantedScreen = false;
                timerScreen.SetActive(true);
                searchTimer = 0f;
            }

            int tempSeg = Mathf.FloorToInt(timer % 60);
            labelTimer.text = tempSeg.ToString();
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(Random.Range(1, escenasJuego.Length));
    }

    public GameObject RandomPersonaje() //GameObject para que devuelva un GameObject
    {
        buscador = Random.Range(0, buscados.Length);
        return Instantiate(buscados[buscador]); //El instantiate es para crear un personaje nuevo basado en la línea de arriba //Ponemos corchete porque es una Array
    }

}
