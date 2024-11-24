using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderArea : MonoBehaviour
{
    // Declaramos las variables globales privadas
    private float _radio;
    private float _height;

    
    // Declaramos el m�todo GetArea()
    private void GetArea()
    {
        // Declaramos la variable local area
        float area = 0.0F;

        // Calculamos el �rea del cilindro
        area = (float)2.0 * Mathf.PI * _radio * (_radio + _height);

        // Mostramos el resultado por pantalla
        Debug.Log("El �rea del cilindro es: " + area);

    }

    // Declaramos el m�todo GetVolume()
    private void GetVolume()
    {
        // Declaramos la variable local volume
        float volume = 0.0F;

        // Calculamos el �rea del cilindro
        volume = Mathf.PI * _radio * _radio * _height;

        // Mostramos el resultado por pantalla
        Debug.Log("El volumen del cilindro es: " + volume);

    }


    // Start is called before the first frame update
    void Start()
    {
        // Inicializamos las variables
        _radio = 5.0f;
        _height = 20.0f;

        // Llamamos al m�todo del �rea
        GetArea();

        // Llamamos al m�todo del volumen
        GetVolume();


    }

}
