using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WantedScreen : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        SetWantedCharacter(GameController.instance.BuscarPersonaje());
    }

    // Update is called once per frame
    private void Update()
    {
        contador.text = timer.ToString("0");
        if (pantallaBuscar == true)
        {
            timer -= Time.deltaTime;
        }

        pantallaBuscar.SetActive(false);
    }

    public void SetWantedCharacter(GameObject personaje)
    {
        //Lo muestra en el spawnPoint
        personaje.transform.position = spawnPoint.transform.position;
        personaje.transform.position = spawnPoint.transform.rotation;
    }
}
