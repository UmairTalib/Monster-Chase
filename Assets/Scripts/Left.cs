using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Left : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update
    bool ispressed = false;
    Animator Anim;
    private SpriteRenderer sr;
    private GameObject player;


    // Update is called once per frame
    void Update()
    {
        if (ispressed)

        {
            player = GameObject.FindGameObjectWithTag(Utils.PLAYER_TAG);
            Anim = player.GetComponent<Animator>();
            Anim.SetBool(Utils.WALK_ANIMATION, true);
            sr=player.GetComponent<SpriteRenderer>();
            sr.flipX = true;
            player.transform.Translate(-10f * Time.deltaTime, 0f, 0f);

        }
        else
        {
            player = GameObject.FindGameObjectWithTag(Utils.PLAYER_TAG);
            Anim = player.GetComponent<Animator>();
            Anim.SetBool(Utils.WALK_ANIMATION, false);
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
