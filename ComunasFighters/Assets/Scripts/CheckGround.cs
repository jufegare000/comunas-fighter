﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    private Player2D player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponentInParent<Player2D>();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        player.grounded = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        player.grounded = false;
    }

}
