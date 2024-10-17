using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    void Start()
    {
        getMultiplesofThreeTwo();
      
    }

    private void getMultiplesofThreeTwo(){
        //Variable local
        string multiplesTwo="";
        string multiplesThree="";

        // Recorremos los números entre 0 y 100
        for(int i = 0; i<=100; i++){
            // Si el resto de la división entre 2 es 0, es un número multiplo de 2
            if((i%2)==0){
                if (multiplesTwo!=""){
                    multiplesTwo += ", "; 
                }
                multiplesTwo += i.ToString(); 
            }
            // Si el resto de la división entre 3 es 0, es un número multiplo de 3
            if((i%3)==0){
                if (multiplesThree!=""){
                    multiplesThree += ", "; 
                }
                multiplesThree += i.ToString(); 
            }
        }

        Debug.Log("El listado de números múltiplos de 2 entre 0 y 100 es: \n" + multiplesTwo);
        Debug.Log("El listado de números múltiplos de 3 entre 0 y 100 es: \n" + multiplesThree);

    }


}
