using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Goal")
        {
            //Debug.Log("Ga);
        }
    }
}
