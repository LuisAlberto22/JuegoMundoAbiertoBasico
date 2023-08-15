using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ControladorDeAudio
{
   public static void ReproducirAudioClip(this AudioSource audioSource , AudioClip audioClip)
   {
		if (!audioSource.isPlaying || audioSource.clip != audioClip)
		{
			audioSource.clip = audioClip;
			audioSource.Play();
		}
   }
}
