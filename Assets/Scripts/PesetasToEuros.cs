using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PesetasToEuros : MonoBehaviour
{
    // Variables globales
    private float _euro;
    public float Peseta;

    // Start is called before the first frame update
    void Start()
    {
        _euro = 0.00601f;

        Debug.Log("El valor de conversión es " + GetPesetaToEuro());
    
    }

    private float GetPesetaToEuro()
    {

        // Variable locales
        float conversion = 0.0f;

        conversion = Peseta * _euro;

        return conversion;
    }
}
