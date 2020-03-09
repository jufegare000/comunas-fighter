using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGroundP2 : MonoBehaviour
{
    private Playe2D2 player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponentInParent<Playe2D2>();
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
