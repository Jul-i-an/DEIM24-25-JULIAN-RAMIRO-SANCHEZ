using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstructurasDeControl : MonoBehaviour
{
    // Variable global
    public int Number1 = 0;
    public int Mumber2 = 0;
    public char Letter;
    public int DayOfWeek = 1;

    // Start is called before the first frame update
    void Start()
    {

        IsPositive();
        
        IsOdd();

        AscOrder();

        IsVowel();

        IsDayOfWeekl();

    }

    private void IsPositive() 
    {

        if (Number1 >= 0)
        {

            Debug.Log("El n�mero " + Number1 + " es positivo.");

        } else {

            Debug.Log("El n�mero " + Number1 + " es negativo.");

        }

    }

    private void IsOdd()
    {

        if ((Number1 % 2) == 0)
        {

            Debug.Log("El n�mero " + Number1 + " es par.");

        } else {

            Debug.Log("El n�mero " + Number1 + " es impar.");

        }

    }

    private void AscOrder()
    {
        if (Number1 > Mumber2)
        {

            Debug.Log("N�mero " + Mumber2 + " es menor que " + Number1 + ".");

        } else if (Number1 == Mumber2) {

            Debug.Log("Los dos n�meros son iguales.");

        } else { 

            Debug.Log("N�mero " + Number1 + " es menor que " + Mumber2 + "."); 

        }

    }
    private void IsVowel()
    {
        // Variable local caracter para calcular de forma f�cil si es Vocal
        char c = char.ToUpper(Letter);    

        // Switch de selecci�n de si es Vocal o Consonante
        switch (c)
        {
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
                Debug.Log(Letter + " es una vocal.");
                break;
            default:
                Debug.Log(Letter +" es una consonante.");
                break;

        }

    }
    private void IsDayOfWeekl()
    {
        if ((DayOfWeek > 7)|| (DayOfWeek <= 0)) {
            Debug.Log("La semana tiene 7 d�as, no " + DayOfWeek + ".");
        } else {
            // Switch de selecci�n del d�a de la semana
            switch (DayOfWeek)
            {
                case 1:
                    Debug.Log("El d�a " + DayOfWeek + " es Lunes.");
                    break;
                case 2:
                    Debug.Log("El d�a " + DayOfWeek + " es Martes.");
                    break;
                case 3:
                    Debug.Log("El d�a " + DayOfWeek + " es Mi�rcoles.");
                    break;
                case 4:
                    Debug.Log("El d�a " + DayOfWeek + " es Jueves.");
                    break;
                case 5:
                    Debug.Log("El d�a " + DayOfWeek + " es Viernes.");
                    break;
                case 6:
                    Debug.Log("El d�a " + DayOfWeek + " es S�bado.");
                    break;
                default:
                    Debug.Log("El d�a " + DayOfWeek + " es Domingo.");
                    break;

            }
        }

    }

}
