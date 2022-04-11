using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Up : MonoBehaviour, IPointerDownHandler , IPointerUpHandler
{
    bool ispressed = false;

    Collision2D collision;
    private bool isGrounded;
    private Rigidbody2D myBody;
    GameObject player;
 
    void FixedUpdate()
    {


        if (ispressed && Player.isGrounded)
        {
            Player.isGrounded = false;
            player = GameObject.FindGameObjectWithTag("Player");
            myBody = player.GetComponent<Rigidbody2D>();
            myBody.AddForce(new Vector2(0f, 14f), ForceMode2D.Impulse);

            

        }
    }
    public void OnPointerDown(PointerEventData evenData)
    {
        ispressed = true;

    }
   public void OnPointerUp(PointerEventData evenData)
    {
        ispressed = false;

    }


}
