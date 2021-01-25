using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class SelecionarVentana : MonoBehaviour
{
    public GameObject VentanaGuerrero;
    public GameObject VentanaGuitarra;
    public GameObject VentanaPiano;
    public GameObject VentanaTigre;

    Animation AVentanaGuerrero;
    Animation AVentanaGuitarra;
    Animation AVentanaPiano;
    Animation AVentanaTigre;

    bool VisibleVGuerrero = false;
    bool VisibleVGuitarra = false;
    bool VisibleVPiano = false;
    bool VisibleVTigre = false;


        void Start()
    {
        AVentanaGuerrero = VentanaGuerrero.GetComponent<Animation>();
        AVentanaGuitarra = VentanaGuitarra.GetComponent<Animation>();
        AVentanaPiano = VentanaPiano.GetComponent<Animation>();
        AVentanaTigre = VentanaTigre.GetComponent<Animation>();
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
        if (VisibleVGuitarra == false)
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

    public void VentanaTigPulsada()
    {
        if (VisibleVTigre == false)
        {
            AVentanaTigre["Tigre"].speed = 1;
            AVentanaTigre.Play();
            VisibleVTigre = true;
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

        if (NombreBoton != "Tigre" & VisibleVTigre == true)
        {
            AVentanaTigre["Tigre"].speed = -1;
            AVentanaTigre["Tigre"].time = AVentanaTigre["Tigre"].length;
            AVentanaTigre.Play();
            VisibleVTigre = false;
        }
    }
}
