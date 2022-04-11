using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool isGrounded = true;
   


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag(Utils.GROUND_TAG))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag(Utils.ENEMY_TAG))
            Destroy(gameObject);


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Utils.ENEMY_TAG))
            Destroy(gameObject);
    }


} // class





























