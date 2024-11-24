using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fibonacci : MonoBehaviour
{
    // Variables globales
    public int Position;

    // Start is called before the first frame update
    void Start()
    {
        int valorPosition = 0;

        valorPosition = GetFibonacciNumber(Position);
        
        if (GetFibonacciNumber(Position) == -1) {

            Debug.Log("Introduce un valor mayor a 0.");

        }
        else
        {

            Debug.Log("La posición " + Position + " corresponde al valor " + valorPosition);

        }
    }

    private int GetFibonacciNumber(int position)
    {
        
        int numberOne = 0,
            numberTwo = 1,
            addition = -1;

        if (position > 0) {

            for (int i = 1; i < position; i++) {

                addition = numberOne + numberTwo;
                numberOne = numberTwo;
                numberTwo = addition;

            }

        }

        return addition;

    }
}
