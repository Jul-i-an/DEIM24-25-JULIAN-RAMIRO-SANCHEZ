using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Month : MonoBehaviour
{
    public int Number;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(getMonth(Number));
    }

    public string getMonth(int number){
        // Variable local
        string diaMes = "El mes correspondiente al número introducido: " + number.ToString() + ", es: " ;

        // Indicamos cuál es el día de la semana o cuál es el incorrecto
        switch (number){
            case 1:
                diaMes += "enero";
                break;
            case 2:
                diaMes += "febrero";
                break;
            case 3:
                diaMes += "marzo";
                break;
            case 4:
                diaMes += "abril";
                break;
            case 5:
                diaMes += "mayo";
                break;
            case 6:
                diaMes += "junio";
                break;
            case 7:
                diaMes += "julio";
                break;
            case 8:
                diaMes += "agosto";
                break;
            case 9:
                diaMes += "septiembre";
                break;
            case 10:
                diaMes += "octubre";
                break;
            case 11:
                diaMes += "noviembre";
                break;
            case 12:
                diaMes += "diciembre";
                break;
            default:
                diaMes = "El valor indicado " + number.ToString() + " no corresponde a ningún mes. \nDebes introducir un valor entre 1 y 12.";
                break;
        }
        return diaMes;
    }
    
}
