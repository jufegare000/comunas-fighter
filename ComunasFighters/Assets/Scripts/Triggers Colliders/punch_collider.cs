using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punch_collider : MonoBehaviour
{
    Player2D player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponentInParent<Player2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //ATENCION A LA HORA DE IMPLEMENTARLO EN LINEA/ONLINE

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Equals ("Player2"))
        {
            player.SetControl_Rival(other.gameObject.GetComponent<Player2D>());
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name.Equals ("Player2"))
        {
            player.SetControl_Rival(null);
        }
    }
}
