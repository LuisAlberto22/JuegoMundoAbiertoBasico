using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDisparo : MonoBehaviour
{
	public static bool Disparo = false;

	public void Disparar(bool d)
	{
		Disparo = d;
	}
}
