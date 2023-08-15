using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaDeMuniciones : Destructible
{
	public int Municiones;

	AudioSource AudioSource;

	private void Start()
	{
		AudioSource = GetComponent<AudioSource>();
		Collider = GetComponent<Collider>();
		MeshRenderer = GetComponent<MeshRenderer>();
	}
	public override void Destruirse()
	{
		DeshabilitarComponentes();
		AudioSource.Play();
		Destroy(gameObject , AudioSource.clip.length);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			Arma arma = other.GetComponentInChildren<Arma>();
			arma.AumentarMunicion(Municiones);
			Destruirse();
		}
	}
}
