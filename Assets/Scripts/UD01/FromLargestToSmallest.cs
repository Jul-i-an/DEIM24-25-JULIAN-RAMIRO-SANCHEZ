using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
{
    // Variables globales
    public int NumberOne;
    public int NumberTwo;
    public int NumberThree;

    // Start is called before the first frame update
    void Start()
    {

        orderLargestToSmallest(NumberOne, NumberTwo, NumberThree);
        
    }
    private void orderLargestToSmallest(int numberOne, int numberTwo, int numberThree)  {
        // Variables locales
        bool ordenado = false;
        int numberAux;

        // Bucle de ordenación
        while (!ordenado){
            if (numberOne < numberTwo) {
                numberAux = numberOne;
                numberOne = numberTwo;
                numberTwo = numberAux;
            }
            else {
                if(numberTwo < numberThree){
                    numberAux = numberTwo;
                    numberTwo = numberThree;
                    numberThree = numberAux;

                }
                else{
                    ordenado =true;
                }

            }
        }
        
        // Mostramos los números ordenados
        Debug.Log("Los números ordenados de mayor a menor son " + numberOne + ", " + numberTwo + ", " + numberThree + ".") ;

    }


    
}
