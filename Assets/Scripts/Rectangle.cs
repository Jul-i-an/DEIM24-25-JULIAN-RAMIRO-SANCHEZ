using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : MonoBehaviour
{
    // Variables globales privadas
    private float _width;
    private float _height;  


    // M�todo �rea
    private void GetArea()
    {

        // Variable local
        float area = 0.0f;

        // Calculamos el �rea del rect�ngulo
        area = _width * _height;

        // Mostramos el �rea del rect�ngulo por Consola
        Debug.Log("El �rea del rect�ngulo es: " + area);

    }


    // M�todo Per�metro
    private void GetPerimeter()
    {
        // Variable local
        float perimeter = 0.0f;

        // Calculamos el per�metro del rect�ngulo
        perimeter = 2 * (_width * _height);

        // Mostramos el per�metro del rect�ngulo por Consola
        Debug.Log("El per�metro del rect�ngulo es: " + perimeter);

    }


    // M�todo Diagonal
    private void GetDiagonal()
    {
        // Variable local
        float diagonal = 0.0f;

        // Calculamos la diagonal del rect�ngulo
        diagonal = Mathf.Sqrt(Mathf.Pow(_width, 2) + Mathf.Pow(_height, 2));

        // Mostramos la diagonal del rect�ngulo por Consola
        Debug.Log("La diagonal del rect�ngulo es: " + diagonal);

    }



    // Start is called before the first frame update
    void Start()
    {
        _width = 12.5f;
        _height = 6.1f;

        // Llamada getArea()
        GetArea();

        // Llamada getPerimetro()
        GetPerimeter();

        // Llamada getDiagonal()
        GetDiagonal();

    }

}
