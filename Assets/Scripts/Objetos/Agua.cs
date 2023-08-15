using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agua : MonoBehaviour
{
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Player") | collision.gameObject.CompareTag("Enemigo"))
		{
			var other = collision.gameObject.GetComponent<Movimiento>();
			other.Realentizar();
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		if (collision.gameObject.CompareTag("Player") | collision.gameObject.CompareTag("Enemigo"))
		{
			var other = collision.gameObject.GetComponent<Movimiento>();
			other.AumentarVelocidad();
		}
	}
}
