using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    private Transform player;
    private Vector3 temPos;
    [SerializeField]
    private float minX, maxX;
    void Start()
    {
        player = GameObject.FindWithTag(Utils.PLAYER_TAG).transform;

    }
    void LateUpdate()
    {
        if (!player)
            return;
        temPos = transform.position;
        temPos.x = player.position.x;
        transform.position = temPos;
        if (temPos.x > maxX)
        {
            temPos.x = maxX;
        }
        if (temPos.x < minX)
        {
            temPos.x = minX;
        }
        transform.position = temPos;

    }
}
