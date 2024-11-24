using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMovement : MonoBehaviour
{
    // Global Variables

    // Private Variables
    [SerializeField]
    private float _speed = 0.8f,
                  _turnSpeed = 90.0f;

    private float _horizontal,
                  _vertical;


    // Update is called once per frame
    void Update()
    {

        // Movement right and left control
        Move();

        // Movement forward and rear control
        Turn();

    }

    // Method to turn the chicken
    private void Turn()
    {

        // Key control W & S & \/ & /\
        _horizontal = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up * _horizontal * _turnSpeed * Time.deltaTime);

    }

    // Method to move the chicken
    private void Move()
    {

        // Key control A & D & < & >
        _vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * _vertical * _speed * Time.deltaTime);

    }


}
