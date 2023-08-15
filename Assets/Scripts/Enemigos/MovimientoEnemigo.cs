using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovimientoEnemigo : Movimiento
{
	public Transform jugador;

	NavMeshAgent nav;
	
	private void Start()
	{
		Animator = GetComponent<Animator>();
		nav = GetComponent<NavMeshAgent>();
	}

	private void Update()
	{
		Animator.SetInteger("Anim", 0);
		if (Mathf.Abs(jugador.position.magnitude - nav.gameObject.transform.position.magnitude) < 10)
		{
			Animator.SetInteger("Anim",1);
			nav.SetDestination(jugador.position);
		}
	}
}
