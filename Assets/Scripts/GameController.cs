using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    public GameObject initialScreen;
    public GameObject wantedScreen;
    public GameObject timerScreen;
    public TextMeshProUGUI labelTimer;
    public TextMeshProUGUI labelSearchTimer;
    public GameObject character;
    public GameObject[] characterChilds;
    public GameObject[] characterPositions;
    public Scene[] escenasJuego;

    public int seg;
    public int searchSeg;
    private float timer;
    private bool isWantedScreen;
    public float searchTimer;

    private void Awake()
    {
        timer = seg;
        searchTimer = searchSeg;

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

    private void Start()
    {
        timerScreen.SetActive(false);
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

    public void RandomCharacter()
    {
        character.transform.GetChild(Random.Range(0, characterChilds.Length)).gameObject.SetActive(true);
    }
}
