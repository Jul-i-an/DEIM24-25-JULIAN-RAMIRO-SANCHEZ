using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxyMovement : MonoBehaviour
{

    //Global Variables
    [Header("Movement")]
    [SerializeField]
    private float _speed = 0.8f,
                  _turnSpeed = 90.0f;

    private float _horizontal,
                  _vertical;

    private Animator _anim;

    private bool _isRunning;

    [Header("Jump")]
    [SerializeField]
    private float _jumpingForce;

    private bool _isJumping;
   
    private Rigidbody _rb;

    [Header("Ray")]
    private Ray _ray;
    
    [SerializeField]
    private float _rayDistance;

    [SerializeField]
    private Transform FoxyPosRot;
    [SerializeField]
    private GameObject Flower;

    [SerializeField]
    private float _thrustZ,
                  _thrustY;

    [SerializeField]
    private float _timeFlower;

    private void Awake() 
    {

        _anim = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();

    }


    // Update is called once per frame
    void Update()
    {
        
        // Movement right and left control
        Move();

        // Movement forward and rear control
        Turn();


        // Movement controlling
        IsMoving();

        // Foxy must jump
        Jump();


        // Jumping controlling
        IsJumping();

        // Flower launch
        flowerLaunch();

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

    // Movement Controller
    private void IsMoving() 
    {

        if (_horizontal == 0 && _vertical == 0)
        {

            // Foxy is not moving. Setting Idle Animation
            _anim.SetBool("isMoving", false);

        }
        else 
        {

            // Foxy is moving. Setting Idle Animation
            _anim.SetBool("isMoving", true);

        }

    }

    // Jumping Controller
    private void IsJumping()
    {

        // Getting the Ray position
        _ray.origin  = transform.position;

        // Getting the ray direction
        _ray.direction = -transform.up;

        // Drawing the ray 
        Debug.DrawRay(_ray.origin, _ray.direction * _rayDistance, Color.red);

        // Verifying a collision
        if (Physics. Raycast(_ray))
        {

            // Foxy is not jumping is over the ground
            _isJumping = false;

        }
        else
        {

            // Foxy is on the air
            _isJumping = true;

        }
        

    }

    // Foxy must jump
    private void Jump() 
    {

        if (Input.GetKeyDown(KeyCode.Space) && !_isJumping) 
        {

            // Doing the jump
            _rb.AddForce(Vector3.up * _jumpingForce);

        }

    }

    // Method to launch flower
    private void flowerLaunch()
    {

        // Verifyn 
        if (Input.GetMouseButtonDown(0))
        {

            // Flower clone creation
            GameObject flowerClone = Instantiate(Flower, FoxyPosRot.position, FoxyPosRot.rotation);

            Rigidbody rbFlower = flowerClone.GetComponent<Rigidbody>();

            rbFlower.AddForce(Vector3.up * _thrustY);

            rbFlower.AddForce(transform.forward * _thrustZ);

            Destroy(flowerClone, _timeFlower);

            // Animation of attack activated
            _anim.SetTrigger("isAttacking");

        }

    }

}
