using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaUsuario : MonoBehaviour, VidaInterfaz
{
	public int Vida;

	public int VidaMaxima;

	public AudioClip[] AudioClips;

	public bool Muerto = false;

	public Action<int> CambioDeVidaEvent { get; set; }
	public Action MuerteEvent { get; set; }

	AudioSource AudioSource;
	public void Muerte()
	{
		if (!Muerto)
		{
			AudioSource.ReproducirAudioClip(AudioClips[1]);
			MuerteEvent();
			Muerto = true;
		}
	}

	public void RecibirCuracion(int cura)
	{
		if (!Muerto)
		{
			if (Vida < 100)
			{
				AudioSource.ReproducirAudioClip(AudioClips[2]);
			}
			Vida = Mathf.Clamp(Vida + cura, 0, VidaMaxima);
			CambioDeVidaEvent(Vida);
		}
	}

	public void RecibirDaño(int daño)
	{
		if (!Muerto)
		{
			Vida = Mathf.Clamp(Vida - daño, 0, VidaMaxima);
			AudioSource.ReproducirAudioClip(AudioClips[0]);
			CambioDeVidaEvent(Vida);
			if (Vida == 0)
			{
				Muerte();
			}
		}
	}

	// Start is called before the first frame update
	void Start()
	{
		AudioSource = GetComponent<AudioSource>();
	}
}
