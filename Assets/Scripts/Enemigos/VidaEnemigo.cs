using System;
using UnityEngine;

public class VidaEnemigo : Destructible, VidaInterfaz
{
	public int Vida;

	public int VidaMaxima;

	AudioSource AudioSource;
	public Action<int> CambioDeVidaEvent { get ; set; }
	public Action MuerteEvent { get; set ; }

	private void Awake()
	{
		MeshRenderer = GetComponent<MeshRenderer>();
		Collider = GetComponent<Collider>();
		AudioSource = GetComponent<AudioSource>();
	}

	public override void Destruirse()
	{
		Destroy(gameObject);
	}

	public void Muerte()
	{
		Destruirse();
	}

	public void RecibirCuracion(int cura)
	{
		Vida = Mathf.Clamp(Vida + cura, 0, VidaMaxima);
	}

	public void RecibirDaño(int daño)
	{
		this.AudioSource.Play();
		Vida = Mathf.Clamp(Vida - daño,0,VidaMaxima);
		if (Vida == 0)
		{
			Muerte();
			return;
		}
		CambioDeVidaEvent(Vida);
	}
}
