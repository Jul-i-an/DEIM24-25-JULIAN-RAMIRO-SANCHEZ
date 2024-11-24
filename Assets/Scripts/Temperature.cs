using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    // Variables globales privadas
    private double _celsius;
    private double _fahrenheit;

    // Metodo de conversi�n de Celsius a Fahrenheit
    private void GetCelsiusToFahrenheit()
    {
        // Variable local
        double conversion = 0.0d;

        // Hacemos la conversi�n de grados
        conversion = (1.8) * _celsius + 32;

        // Mostramos el resultado por pantalla
        Debug.Log(_celsius + " grados celsius corresponden a " + conversion + " grados fahrenheit.");

    }

    // Metodo de conversi�n de Fahrenheit a Celsius
    private void GetFahrenheitToCelsius() 
    {
        // Variable local
        double conversion = 0.0d;

        // Hacemos la conversi�n de grados
        conversion = (double)(_fahrenheit - 32) / 1.8;

        // Mostramos el resultado por pantalla
        Debug.Log(_fahrenheit + " grados fahrenheit corresponden a " + conversion + " grados celsius.");

    }


    // Start is called before the first frame update
    void Start()
    {
        // Inicializamos las variables globales
        _celsius = 25.0d;
        _fahrenheit = 107.0d;

        // Llamamos al m�todo de conversi�n de Celsius a Fahrenheit
        GetCelsiusToFahrenheit();

        // Llamamos al m�todo de conversi�n de Fahrenheit a Celsius
        GetFahrenheitToCelsius();

    }





}
