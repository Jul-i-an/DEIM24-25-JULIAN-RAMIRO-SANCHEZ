using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DolarsToEuros : MonoBehaviour
{
    
    // Variables globales
    private float _euro;
    public float Dollar;

    // Start is called before the first frame update
    void Start()
    {
        _euro = 0.90f;

        Debug.Log("El valor de conversión es " + GetDollarToEuro());
    }

    private float GetDollarToEuro()
    {

        // Variable locales
        float conversion = 0.0f;

        conversion = Dollar * _euro;

        return conversion;
    }

}
