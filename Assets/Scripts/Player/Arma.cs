using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Arma : MonoBehaviour
{
	public int Municiones;

	public Action<int> CambioDeMunicion;


	public int MunicionesMax;

	public GameObject bala;

	private float desfase = 0.1f;

	AudioSource AudioSource;
	void disparar()
	{
		if (Municiones > 0)
		{
			var clon = Instantiate(bala, transform.position,transform.rotation);
			Municiones--;
			CambioDeMunicion(Municiones);
			this.AudioSource.Play();
			Destroy(clon, 2f);
		}
	}

	private void Start()
	{
		AudioSource = GetComponent<AudioSource>();
	}
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.P) | ControlDisparo.Disparo)
		{
			disparar();
		}

		//if (ControlDisparo.Disparo)
		//{
		//          desfase -= Time.deltaTime;
		//	if (desfase <= 0)
		//	{
		//              disparar();
		//              desfase = 0.1f;
		//	}
		//      }
	}
	public void AumentarMunicion(int municion)
	{
		Municiones = Mathf.Clamp(Municiones + municion, 0, MunicionesMax);
		CambioDeMunicion(Municiones);
	}
}
