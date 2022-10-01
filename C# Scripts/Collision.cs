using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32 (1, 1, 1, 1); 


    [SerializeField] float destroyDelay = 0.5f; 
    bool hasPackage = false; 
    //Add ur rigid bodys and collisions do not forget to set gravity to zero for certain games
    SpriteRenderer spriteRenderer; 
    //allows us to use sprite renderer wherever we want 
    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Oof"); 
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Packaged Picked Up"); 
            hasPackage = true; 
            spriteRenderer.color = hasPackageColor; 
            Destroy(other.gameObject, destroyDelay); 
        }
        if(other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Packaged Devliverd!"); 
            hasPackage = false;
            spriteRenderer.color = noPackageColor;  
        }
    }
}
