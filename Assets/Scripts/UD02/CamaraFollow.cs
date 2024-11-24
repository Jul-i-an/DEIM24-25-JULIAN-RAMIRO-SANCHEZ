using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{
    // Global variables
    [SerializeField]
    private float _smoothing;

    private Vector3 _offset;



    public Transform Target;

    // Taking the camara position
    void Start()
    {


        _offset = transform.position - Target.position;
        _smoothing = 0.9f;

    }

    // Update is called once per frame
    void Update()
    {
        // Taking the camara position
        Vector3 cameraPosition = Target.position + _offset;

        // Setting the new camara position
        transform.position = Vector3.Lerp(transform.position, cameraPosition, _smoothing * Time.deltaTime);
    }

}
