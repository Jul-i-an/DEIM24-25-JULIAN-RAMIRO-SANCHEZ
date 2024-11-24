using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExercices : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
       
        GetPositiveNumbers();
        GetNegativeNumbers();

    }

    private void GetPositiveNumbers()
    {
        // Variable local array
        int[] numbersArray = new int[10] { 24, -56, 8, 12, -54, 34, -26, -87, 93, 0 };
        
        for (int i = 0; i < numbersArray.Length; i++)
        {
            if (numbersArray[i] >= 0)
            {
                Debug.Log(numbersArray[i]);
            }

        }
    }
    private void GetNegativeNumbers()
    {
        // Variable local array
        int[] numbersArray = new int[10] { 24, -56, 8, 12, -54, 34, -26, -87, 93, 0 };
        
        for (int i = 0; i < numbersArray.Length; i++)
        {
            if (numbersArray[i] < 0)
            {
                Debug.Log(numbersArray[i]);
            }

        }

    }

}
