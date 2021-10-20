using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{   
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] float destroyDelay = .2f;

    SpriteRenderer spriteRenderer;
    bool hasPackage;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        print("You collided with something");
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Package" && !hasPackage)
        {
            spriteRenderer.color = hasPackageColor;
            print("Package Picked up!");
            hasPackage = true;
            Destroy(other.gameObject ,destroyDelay);
        }
        
        if(other.tag == "DropPoint" && hasPackage)
        {
            print("Package Dropped at the home");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }   
    }
}
