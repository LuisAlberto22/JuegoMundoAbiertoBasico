using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
	public float vel = 3f,
	   rotate = 150f;

    protected Rigidbody rb;

    public bool Realentizado = false;

	protected Animator Animator;

	private void Start()
	{
		rb = GetComponent<Rigidbody>();
		Animator = GetComponent<Animator>();
	}

	public void Realentizar()
	{
		if (!Realentizado)
		{
		  Animator.speed /= 2;
          vel /= 2;
          Realentizado = true;
		}
	}

    public void AumentarVelocidad()
	{
		if (Realentizado)
		{
			Animator.speed *= 2;
			vel = 3f;
			Realentizado = false;
		}
	}

}
