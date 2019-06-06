﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public GameObject UIControls;
    public GameObject UICredits;

    public static bool ControlsIsOn = false;
    public static bool CreditsIsOn = false;

    //Llamamos a funciones públicas con el botón derecho en el inspector del componente
    [ContextMenu("LoadGame")]
    private void Start()
    {
        UIControls.SetActive(false);
        UICredits.SetActive(false);
    }

    public void LoadGame()
	{
		//Carga la escena que esté en el índice 1 de File > Build Settings > Scenes
		SceneManager.LoadScene(1);
	}

	public void QuitGame()
	{
		//Cierra la aplicación (solo en Build)
		Application.Quit();
	}

	protected void LoadMainMenu()
	{
		//Carga la escena que esté en el índice 0 de File > Build Settings > Scenes
		SceneManager.LoadScene(0);
	}

    public void Controls()
    {
        //Muestra el panel de controles
        UIControls.SetActive(true);
        ControlsIsOn = true;
    }

    public void Credits()
    {
        //Muestra el panel de créditos
        UICredits.SetActive(true);
        CreditsIsOn = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (ControlsIsOn || CreditsIsOn)
            {
                Return();
            }
        }
    }

    public void Return()
    {
        //Vuelta al menú principal (desde controls o credits)
        UIControls.SetActive(false);
        UICredits.SetActive(false);
        ControlsIsOn = false;
        CreditsIsOn = false;
    }
}
