using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuerteCanvas : MonoBehaviour
{
	Canvas CanvasMuerte;

	public VidaUsuario Muerte;

	
	private void Start()
	{
		CanvasMuerte = GetComponent<Canvas>();
		Muerte.MuerteEvent += new Action(() 
			=> CanvasMuerte.enabled = true);
	}
}
