using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour
{
    public int daño;

	public float tiempo = 0;

	public bool atacando;

	private void Update()
	{
		if (atacando)
		{
			tiempo -= Time.deltaTime;
		}
	}

	private void OnCollisionStay(Collision collision)
	{
		if (tiempo <= 0 & collision.gameObject.CompareTag("Player"))
		{
			collision.gameObject.GetComponent<VidaUsuario>().RecibirDaño(daño);
			atacando = true;
			tiempo = 2;
		}
	}
	private void OnCollisionExit(Collision collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			atacando = false;
			tiempo = 0;
		}
	}

}
