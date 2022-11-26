using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    // private int noOfPackagesHeld;
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);
    bool hasPackage = false;

    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    [SerializeField] float delay = 0.5f;
    void OnCollisionEnter2D(Collision2D other) {
            Debug.Log("OOF its Gone wRonG");
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package" && !hasPackage){
            // noOfPackagesHeld +=1;
            Debug.Log("Package picked");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject,delay);
            

        }
        //&& noOfPackagesHeld > 0
        if(other.tag == "Customer" && hasPackage){
            Debug.Log("Package Delievered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
            // noOfPackagesHeld -=1;
        }
    }
    
}
