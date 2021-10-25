using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    PlayerMovement pm;
    void Start()
    {
        pm = transform.parent.GetComponent<PlayerMovement>();
    }

    void OnTriggerEnter2D()
    {
        
        if(pm.doubleJump == true)
        {
            pm.canJump = 2;
        }

        else
        {
            pm.canJump = 1;
        }
    }

    void OnTriggerExit2D()
    {
        if(pm.doubleJump == true && pm.canJump == 2)
        {
            pm.canJump = 1;
        }
        else if(pm.doubleJump == false)
        {
            pm.canJump = 0;
        }
    }
}
