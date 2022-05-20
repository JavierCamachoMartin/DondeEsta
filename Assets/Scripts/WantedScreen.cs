using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WantedScreen : MonoBehaviour
{
    public static WantedScreen instance;

    public TextMeshProUGUI contador;
    public float timer;
    public GameObject pantallaBuscar;
    public GameObject spawnPoint;

    void Awake()
    {
        if (WantedScreen.instance == null)
        {
            WantedScreen.instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        SetWantedCharacter(GameController.instance.RandomPersonaje());
    }

    // Update is called once per frame
    void Update()
    {
        //Controla el tiempo que esta activa y cuando se quita la pantalla
        contador.text = timer.ToString("0");
        if (pantallaBuscar == true)
        {
            timer -= Time.deltaTime;
        }

        if(timer <= 0)
        {
            pantallaBuscar.SetActive(false);
            //Tambien hay que apagar el personaje con la pantalla
            GameController.instance.persona.SetActive(false);
        }
    }

    public void SetWantedCharacter(GameObject personaje)
    {
        //Lo muestra en el spawnPoint
        personaje.transform.position = spawnPoint.transform.position;
        
    }
}
