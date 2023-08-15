using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlladorCanvas : MonoBehaviour
{
    Slider Slider;

	VidaEnemigo VidaEnemigo;

	Transform Jugador;

    Text Text;

	private void Awake()
	{
		VidaEnemigo = GetComponentInParent<VidaEnemigo>();
		Jugador = GameObject.FindWithTag("MainCamera").transform;
		Text = GetComponentInChildren<Text>();
		Slider = GetComponentInChildren<Slider>();

		Slider.maxValue = VidaEnemigo.VidaMaxima;
		VidaEnemigo.CambioDeVidaEvent += new System.Action<int>(RefrescarVidaHUD);
	}

	private void Update()
	{
		transform.rotation = Quaternion.LookRotation(transform.position - Jugador.transform.position);
	}

	private void RefrescarVidaHUD(int vida)
	{
		Text.text = string.Format($"{vida}%");
		Slider.value = vida;
	}
		
}
