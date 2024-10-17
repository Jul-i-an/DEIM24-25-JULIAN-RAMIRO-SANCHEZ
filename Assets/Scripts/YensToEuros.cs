using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YensToEuros : MonoBehaviour
{
    // Variables globales
    private float _euro;
    public float Yen;

    // Start is called before the first frame update
    void Start()
    {
        _euro = 0.0063f;

        Debug.Log("El valor de conversión es " + GetYenToEuro());

    }

    private float GetYenToEuro()
    {

        // Variable locales
        float conversion = 0.0f;

        conversion = Yen * _euro;

        return conversion;
    }

}
