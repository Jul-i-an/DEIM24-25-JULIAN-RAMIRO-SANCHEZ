using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieControl : MonoBehaviour
{
    // Method to control the collision
    private void OnCollisionEnter(Collision infoCollision)
    {

        if (infoCollision.gameObject.tag == "flowerAttack")
        {

            Destroy(gameObject);

        }

    }

}
