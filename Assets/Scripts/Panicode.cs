using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panicode : MonoBehaviour
{
    public char Letra;
    public int numeroDia;


    void Start()
    {
        GetDiaLetras();
    }

    private void GetDiaLetras()
    {

        string resultLetra;
        string resultDia="";

        if (Letra == 'a' || Letra == 'e' || Letra == 'i' || Letra == 'o' || Letra == 'u')
        {
            resultLetra = "Esta letra es una vocal";
        }
        else
        {
            resultLetra = "Esta letra es una consonante";
        }

        if (numeroDia == 1)
        {
            resultDia = "Ese dia es el Lunes";
        }
        if (numeroDia == 2)
        {
            resultDia = "Ese dia es el Martes";
        }
        if (numeroDia == 3)
        {
            resultDia = "Ese dia es el Miercoles";
        }
        if (numeroDia == 4)
        {
            resultDia = "Ese dia es el Jueves";
        }
        if (numeroDia == 5)
        {
            resultDia = "Ese dia es el Viernes";
        }
        if (numeroDia == 6)
        {
            resultDia = "Ese dia es el Sabado";
        }
        if (numeroDia == 7)
        {
            resultDia = "Ese dia es el Domingo";
        }
        if (numeroDia > 7)
        {
            resultDia = "Solo hay 7 dias a la semana";
        }

        Debug.Log(resultLetra);
        Debug.Log(resultDia);
    }
}
