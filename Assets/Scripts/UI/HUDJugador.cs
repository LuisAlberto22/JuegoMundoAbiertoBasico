using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDJugador : MonoBehaviour
{

	public Image SliderVida;

	public Slider Slider;

	public Text TextoVida;

	public Text Balas;

	public Text Capsulas;

	public Controlador controlador;

	public GameObject Jugador;

	private void Start()
	{
		Jugador.GetComponent<VidaUsuario>()
			.CambioDeVidaEvent += new System.Action<int>(ActualizarVida);
		Jugador.GetComponent<ContadorDeCapsulas>()
			.CapsulaRecogida += new System.Action<int>(ActualizarCapsulas);
		var Arma = Jugador.GetComponentInChildren<Arma>();
		Arma.CambioDeMunicion += new System.Action<int>(ActualizarBalas);
		int Municiones = Arma.Municiones;
		ActualizarBalas(Municiones);
		ActualizarCapsulas(0);
	}

	private void ActualizarBalas(int Balas)
	{
		int cantidadMaxima = Jugador.GetComponentInChildren<Arma>().MunicionesMax;
		this.Balas.text = string.Format($"Balas: {Balas}/{cantidadMaxima}");
	}

	private void ActualizarCapsulas(int Capsulas)
	{
		this.Capsulas.text = string.Format($"Capsulas: {Capsulas}/{controlador.CantidadMaximaDeCapsulas}");
	}

	private void ActualizarVida(int Vida)
	{
		TextoVida.text = string.Format($"{Vida}%");
		Slider.value = Vida;
		CambioDeColor(Vida);
	}

	private void CambioDeColor(int valor)
	{
		if (valor > 70)
		{
			SliderVida.color = Color.green;
		}
		else if (valor > 30)
		{
			SliderVida.color = new Color(255,115,0);
		}
		else
		{
			SliderVida.color = Color.red;
		}
	}
}
