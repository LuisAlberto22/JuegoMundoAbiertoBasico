using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticulasDaño : MonoBehaviour
{
	public int daño;
	private void OnTriggerStay(Collider other)
	{
		VidaInterfaz gameobject = other.GetComponent<VidaInterfaz>();
		gameobject.RecibirDaño((int)(daño * Time.deltaTime));
	}
}
