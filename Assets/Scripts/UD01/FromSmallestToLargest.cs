using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{
    // Variables globales
    public int NumberOne;
    public int NumberTwo;
    public int NumberThree;

    // Start is called before the first frame update
    void Start()
    {

        orderSmallestToLargest(NumberOne, NumberTwo, NumberThree);
        
    }
    private void orderSmallestToLargest(int numberOne, int numberTwo, int numberThree)  {
        bool ordenado = false;
        int numberAux;

        // Bucle de ordenación
        while (!ordenado){
            if (numberOne > numberTwo) {
                numberAux = numberOne;
                numberOne = numberTwo;
                numberTwo = numberAux;
            }
            else {
                if(numberTwo > numberThree){
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
        Debug.Log("Los números ordenados de menor a mayor son " + numberOne + ", " + numberTwo + ", " + numberThree + ".") ;

    }


    
}
