using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    // private int noOfPackagesHeld;
    bool hasPackage = false;
    void OnCollisionEnter2D(Collision2D other) {
            Debug.Log("OOF its Gone wRonG");
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package"){
            // noOfPackagesHeld +=1;
            Debug.Log("Package picked");
            hasPackage = true;

        }
        //&& noOfPackagesHeld > 0
        if(other.tag == "Customer" && hasPackage){
            Debug.Log("Package Delievered");
            hasPackage = false;
            // noOfPackagesHeld -=1;
        }
    }
    
}
