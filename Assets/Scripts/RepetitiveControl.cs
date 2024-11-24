using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepetitiveControl : MonoBehaviour
{
    //Variables globales
    public int Number = 1 ;
    private int _top100 = 100;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("===================================");
        Debug.Log("   Cuenta incremental de 1 a 100   ");
        incrementalCount();
        Debug.Log("============= FIN =================\n\n");
        
        Debug.Log("===================================");
        Debug.Log("   Cuenta decreciente de 1 a 100   ");
        decrementalCount();
        Debug.Log("============= FIN =================\n\n");

        Debug.Log("===================================");
        Debug.Log("   Final Count de 1 hasta " + Number );
        finalCountDown();
        Debug.Log("============= FIN =================");
    }

    private void incrementalCount() {

        for (int i = 1; i <= _top100; i++) {
            Debug.Log("Número: " + i);
        }

    }

    private void decrementalCount()
    {

        for (int i = _top100; 0 <= i; i--)
        {
            Debug.Log("Número: " + i);
        }

    }

    private void negativeCount()
    {

        for (int i = 1; _top100 <= i; i--)
        {
            Debug.Log("Número: " + i);
        }

    }

    private void finalCountDown() {

        if (Number != 1) {
            _top100 = Number;
        }

        if (Number > 1){
            incrementalCount();

        } else if (Number == 1){
            Debug.Log("Número: " + Number);

        } else {
            negativeCount();

        }

    }

}
