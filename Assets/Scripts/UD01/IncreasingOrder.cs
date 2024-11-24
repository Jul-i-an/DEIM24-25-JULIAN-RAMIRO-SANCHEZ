using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{
    // Variables globales
    public int NumberOne;
    public int NumberTwo;
    public int NumberThree;

    // Start is called before the first frame update
    void Start()
    {
        increasingOrder(NumberOne, NumberTwo, NumberThree);
    }

    private void increasingOrder(int numberOne, int numberTwo, int numberThree){
        if((numberOne < numberTwo) && (numberTwo < numberThree)){
            Debug.Log("Números introducidos en orden creciente.");
        }else{
            Debug.Log("Números NO introducidos en orden creciente.");
        }
    }

}
