using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirWhatsapp : MonoBehaviour
{
    public void AbrirWP()
    {
        Application.OpenURL("https://api.whatsapp.com/send?phone=51986146761&text=hola!");
    }


}
