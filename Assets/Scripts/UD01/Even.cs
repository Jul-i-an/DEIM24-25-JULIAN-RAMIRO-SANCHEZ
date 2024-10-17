using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Even : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        getEvenNumbers();
    }

    private void getEvenNumbers(){
        //Variable local
        string numberString="";

        // Recorremos los números entre 0 y 100
        for(int i = 0; i<=100; i++){
            // Si el resto de la división entre 2 es diferente de 0, es un número imgpar
            if((i%2)!=0){
                if (numberString!=""){
                    numberString += ", "; 
                }
                numberString += i.ToString(); 
            }
            
        }

        Debug.Log("El listado de números impares entre 0 y 100 es: \n" + numberString);

    }

}
