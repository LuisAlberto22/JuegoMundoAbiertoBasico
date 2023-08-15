using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsulas : Destructible
{
	public int cura;

	public ParticleSystem ParticleSystem;

	AudioSource AudioDestruccion;

	private void Start()
	{
		Collider = GetComponent<Collider>();
		MeshRenderer = GetComponent<MeshRenderer>();
		AudioDestruccion = GetComponent<AudioSource>();
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			collision.gameObject
				.GetComponent<VidaUsuario>()
				.RecibirCuracion(cura);
			collision
				.gameObject
				.GetComponent<ContadorDeCapsulas>()
				.AumentarCapsulas();
			Destruirse();
		}
	}

	new void DeshabilitarComponentes()
	{
		base.DeshabilitarComponentes();
		ParticleSystem.gameObject.SetActive(false);
	}

	public override void Destruirse()
	{
		DeshabilitarComponentes();
		AudioDestruccion.Play();
		Destroy(gameObject,AudioDestruccion.clip.length);
	}
}
