using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
        void Start()
    {
        getMultiplesofThree();
      
    }

    private void getMultiplesofThree(){
        //Variable local
        string multiplesThree="";

        // Recorremos los números entre 0 y 100
        for(int i = 0; i<=100; i++){
            // Si el resto de la división entre 3 es 0, es un número multiplo de 3
            if((i%3)==0){
                if (multiplesThree!=""){
                    multiplesThree += ", "; 
                }
                multiplesThree += i.ToString(); 
            }
        }

        Debug.Log("El listado de números múltiplos de 3 entre 0 y 100 es: \n" + multiplesThree);

    }
}
