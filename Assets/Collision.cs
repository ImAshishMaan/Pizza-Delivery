using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) 
    {
        print("You collided with something");
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        print("You picked the item;");      
    }
}
