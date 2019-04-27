using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
	//Llamamos a funciones públicas con el botón derecho en el inspector del componente
	[ContextMenu("LoadGame")]
	
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
}
