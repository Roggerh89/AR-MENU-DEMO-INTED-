using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; //acceder biblioteca de Unity


public class SelecionarVentana : MonoBehaviour
{
    //variables publicas
    public GameObject VentanaGuerrero;
    public GameObject VentanaGuitarra;
    public GameObject VentanaPiano;

    //variable privadas
    Animation AVentanaGuerrero;
    Animation AVentanaGuitarra;
    Animation AVentanaPiano;

     //variable ver si esta visible o no
    bool VisibleVGuerrero = false;
    bool VisibleVGuitarra = false;
    bool VisibleVPiano = false;



        void Start()
    {
        //iniciaremos la ventana Aventana con os componentes Animation
        AVentanaGuerrero = VentanaGuerrero.GetComponent<Animation>();
        AVentanaGuitarra = VentanaGuitarra.GetComponent<Animation>();
        AVentanaPiano = VentanaPiano.GetComponent<Animation>();
       
    }

    public void VentanaGuePulsada()
    {
        if (VisibleVGuerrero == false)
        {
            AVentanaGuerrero["Guerrero"].speed = 1;
            AVentanaGuerrero.Play();
            VisibleVGuerrero = true;
        }
    }

    public void VentanaGuiPulsada()
    {
        if (VisibleVGuitarra == false) //si es falso se ejecutara la animacion
        {
            AVentanaGuitarra["Guitarra"].speed = 1;
            AVentanaGuitarra.Play();
            VisibleVGuitarra = true;
        }
    }

    public void VentanaPiaPulsada()
    {
        if (VisibleVPiano == false)
        {
            AVentanaPiano["Piano"].speed = 1;
            AVentanaPiano.Play();
            VisibleVPiano = true;
        }
    }

   

    public void VentanaNoPulsada()
    {
        string NombreBoton = EventSystem.current.currentSelectedGameObject.name;

        if (NombreBoton != "Guerrero" & VisibleVGuerrero == true)
        {
            AVentanaGuerrero["Guerrero"].speed = -1;
            AVentanaGuerrero["Guerrero"].time = AVentanaGuerrero["Guerrero"].length;
            AVentanaGuerrero.Play();
            VisibleVGuerrero = false;
        }

        if (NombreBoton != "Guitarra" & VisibleVGuitarra == true)
        {
            AVentanaGuitarra["Guitarra"].speed = -1;
            AVentanaGuitarra["Guitarra"].time = AVentanaGuitarra["Guitarra"].length;
            AVentanaGuitarra.Play();
            VisibleVGuitarra = false;
        }

        if (NombreBoton != "Piano" & VisibleVPiano == true)
        {
            AVentanaPiano["Piano"].speed = -1;
            AVentanaPiano["Piano"].time = AVentanaPiano["Piano"].length;
            AVentanaPiano.Play();
            VisibleVPiano = false;
        }

       
    }
}
