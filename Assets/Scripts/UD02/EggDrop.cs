using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggDrop : MonoBehaviour
{
    // Global Variables
    [SerializeField] 
    private GameObject _egg;

    [SerializeField] 
    private Transform _chickenAss;

    [SerializeField]
    private float _eggLifeTime;

    void Awake() 
    {
        
        // Taking the egg generator position
        _chickenAss = GetComponent<Transform>();

        // Setting the egg lifetime
        _eggLifeTime = 3f;

    }

    // Update is called once per frame
    void Update()
    {

        // Llamamos a la creación del Huevo
        eggGenerator();

    }

    private void eggGenerator() {

        if (Input.GetMouseButtonDown(0))
        {
            
            // Creamos un nuevo huevo
            GameObject newEgg = Instantiate(_egg, _chickenAss.position, _chickenAss.rotation);

            // Destruimos al huevo después de tres segundos
            Destroy(newEgg, _eggLifeTime);

        }
    }
}
