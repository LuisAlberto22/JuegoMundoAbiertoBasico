using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Controlador : MonoBehaviour
{

	public int CantidadMaximaDeCapsulas { get; set; }

	public ContadorDeCapsulas contador;

	private void Awake()
	{
		CantidadMaximaDeCapsulas = GameObject.FindGameObjectsWithTag("coin").Length;
		contador.CapsulaRecogida += new System.Action<int>(VerificarVictoria);
	}

	private void VerificarVictoria(int @object)
	{
		if (@object >= CantidadMaximaDeCapsulas)
		{
			NivelCompletado();
		}
	}

	private void NivelCompletado()
	{
		CargarEscena(2);
	}

	public void CargarEscena(int index)
	{
		UnityEngine
			.SceneManagement
			.SceneManager
			.LoadScene(index);
	}

}
