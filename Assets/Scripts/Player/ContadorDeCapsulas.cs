using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorDeCapsulas : MonoBehaviour
{
    public int Capsulas;

	public Action<int> CapsulaRecogida;

    public void AumentarCapsulas()
	{
		Capsulas += 1;
		CapsulaRecogida(Capsulas);
	}

}
