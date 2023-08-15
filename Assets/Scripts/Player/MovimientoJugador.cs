using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : Movimiento
{
    public bool jump = false;

    public float force = 250f;

    public AudioClip AudioClip;

    AudioSource AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Animator = GetComponent<Animator>();
        AudioSource = GetComponent<AudioSource>();

    }

    private void Saltar()
	{
        rb.AddForce(0, force, 0);
        jump = !jump;
        AudioSource.ReproducirAudioClip(AudioClip);
        Animator.SetInteger("Velocidad",2);
        //if (!audio.isPlaying)
        //{
        //    reproducir(5, 10);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        Animator.SetInteger("Velocidad", 0);
        //mover adelante
        if (Input.GetKey(KeyCode.W))
		{
            Animator.SetInteger("Velocidad", 1);
            transform.Translate(new Vector3(0, 0, vel) * Time.deltaTime);
		}
        //fin adelante
        //mover atras
        if (Input.GetKey(KeyCode.S))
		{
            Animator.SetInteger("Velocidad", 1);
            transform.Translate(new Vector3(0, 0, -vel) * Time.deltaTime);
		}
        //fin atras
        //mover Derecha
        if (Input.GetKey(KeyCode.D))
		{
            transform.Rotate(new Vector3(0, rotate, 0) * Time.deltaTime);
            Animator.SetInteger("Velocidad", 1);
        }
        //fin Derecha
        //mover Izquierda
        if (Input.GetKey(KeyCode.A))
		{
            Animator.SetInteger("Velocidad", 1);
            transform.Rotate(new Vector3(0, -rotate, 0) * Time.deltaTime);
		}
        //fin Izquierda
        //salto
        if ((Input.GetKeyDown(KeyCode.Space)| ControlSalto.salto )&& jump)
        {
            Saltar();
        }
        //fin salto
        ControlNaveVirtual();
    }
    //public void reproducir(float inicio, float final)
    //{
    //    audio.time = inicio;
    //    audio.Play();
    //    if (audio.isPlaying && audio.time >= final)
    //    {
    //        audio.Stop();
    //    }
    //}

    void ControlNaveVirtual()
    {
        if (ControlVirtual.inputVector.z != 0)
        {
            transform.Translate(new Vector3
                (0,0, ControlVirtual.inputVector.z * vel)
                * Time.deltaTime);
            Animator.SetInteger("Velocidad", 1);
        }

        if (ControlVirtual.inputVector.x != 0)
        {
            transform.Rotate(new Vector3
                (0, ControlVirtual.inputVector.x * rotate,0)
                * Time.deltaTime);
            Animator.SetInteger("Velocidad", 1);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (!jump && collision.gameObject.tag == "ground")
        {
            jump = !jump;
        }
    }
}
