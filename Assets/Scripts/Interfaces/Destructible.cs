using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Destructible : MonoBehaviour
{
	protected MeshRenderer MeshRenderer { get; set; }

	protected Collider Collider { get; set; }

	protected void DeshabilitarComponentes()
	{
		MeshRenderer.enabled = false;
		Collider.enabled = false;
	}
	public abstract void Destruirse();
}
