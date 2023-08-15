using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balas : MonoBehaviour
{
	public int daño;
	private void Update()
	{
		transform.Translate(new Vector3(0, 0, 10) * Time.deltaTime);
	}

	private void OnCollisionEnter(Collision collision)
	{
		VidaInterfaz enemigo = collision.gameObject.GetComponent<VidaInterfaz>();
		enemigo.RecibirDaño(daño);
		Destroy(this.gameObject);
	}

}
