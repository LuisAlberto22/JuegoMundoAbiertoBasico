using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticulasVida : MonoBehaviour
{
    public int curacion;


	private void OnTriggerStay(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			VidaUsuario jugador = other.GetComponent<VidaUsuario>();
			jugador.RecibirCuracion((int)(curacion * Time.deltaTime));
		}
	}

}
