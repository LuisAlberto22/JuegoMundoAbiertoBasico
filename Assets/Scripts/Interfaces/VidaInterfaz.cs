using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

interface VidaInterfaz
{
    Action<int> CambioDeVidaEvent { get; set; }
    Action MuerteEvent { get; set; }
    void RecibirDaño(int daño);
    void Muerte();
    void RecibirCuracion(int cura);
}
