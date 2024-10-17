using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : MonoBehaviour
{
    // Variables globales privadas
    private float _width;
    private float _height;  


    // Método área
    private void GetArea()
    {

        // Variable local
        float area = 0.0f;

        // Calculamos el área del rectángulo
        area = _width * _height;

        // Mostramos el área del rectángulo por Consola
        Debug.Log("El área del rectángulo es: " + area);

    }


    // Método Perímetro
    private void GetPerimeter()
    {
        // Variable local
        float perimeter = 0.0f;

        // Calculamos el perímetro del rectángulo
        perimeter = 2 * (_width * _height);

        // Mostramos el perímetro del rectángulo por Consola
        Debug.Log("El perímetro del rectángulo es: " + perimeter);

    }


    // Método Diagonal
    private void GetDiagonal()
    {
        // Variable local
        float diagonal = 0.0f;

        // Calculamos la diagonal del rectángulo
        diagonal = Mathf.Sqrt(Mathf.Pow(_width, 2) + Mathf.Pow(_height, 2));

        // Mostramos la diagonal del rectángulo por Consola
        Debug.Log("La diagonal del rectángulo es: " + diagonal);

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
