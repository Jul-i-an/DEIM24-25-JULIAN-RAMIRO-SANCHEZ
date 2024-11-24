using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour
{
    
    // Variables globales privadas
    private double _grams;


    // Declaración del método GetPounds
    private void GetPounds()
    {
        // Variable local
        double pound = 0.0d;

        // Realizamos el cálculo de las libras
        pound = _grams * 0.00220462;

        // Mostramos el resultado por pantalla
        Debug.Log(_grams + " gramos son " + pound + " libras.");

    }

    // Declaración del método GetOunce
    private void GetOunce()
    {
        // Variable local
        double ounce = 0.0d;

        // Realizamos el cálculo de las libras
        ounce = _grams * 0.035274;

        // Mostramos el resultado por pantalla
        Debug.Log(_grams + " gramos son " + ounce + " Onzas.");

    }

    // Declaración del método GetKilograms
    private void GetKilograms()
    {
        // Variable local
        double kilogram = 0.0d;

        // Realizamos el cálculo de las libras
        kilogram = _grams / 1000;

        // Mostramos el resultado por pantalla
        Debug.Log(_grams + " gramos son " + kilogram + " kilogramos.");

    }


    // Start is called before the first frame update
    void Start()
    {
        // Inicializamos las variables globales
        _grams = 1500.0d;

        // Llamada al metodo de conversión de gramos a libras
        GetPounds();


        // Llamada al metodo de conversión de gramos a Onzas
        GetOunce();


        // Llamada al metodo de conversión de gramos a Kilogramos
        GetKilograms();


    }

}
