using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListsExercices : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        //Variable local
        List<int>numberList = new List<int>() { 24, -56, 8, 12, -54, 34, -26, -87, 93, 0};    

        

        // Agregamos los números a la lista
        // 24, -56, 8, 12, -54, 34, -26, -87, 93, 0
        numberList.Add(-1);
        
        GetPositiveNumbers(numberList);

        GetNegativeNumbers(numberList);

    }
    private void GetPositiveNumbers(List<int>numberList){
        foreach (var number in numberList)
        {
            if (number >= 0){
                Debug.Log(number);
            }
        }

    }
    private void GetNegativeNumbers(List<int>numberList){
        foreach (var number in numberList)
        {
            if (number < 0){
                Debug.Log(number);
            }
        }
        
    }

}
