using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scene = UnityEngine.SceneManagement;

public class SceneMananger : MonoBehaviour
{
	public void CargarEscena(int index)
	{
		Scene.SceneManager.LoadScene(index);
	}

	public void Salir()
	{
		Application.Quit();
	}

}
