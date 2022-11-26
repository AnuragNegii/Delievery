using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private int noOfPackagesHeld;
    void OnCollisionEnter2D(Collision2D other) {
            Debug.Log("OOF its Gone wRonG");
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package"){
            noOfPackagesHeld +=1;
            Debug.Log("Package picked");

        }
        if(other.tag == "Customer" && noOfPackagesHeld > 0){
            Debug.Log("Package Delievered");
            noOfPackagesHeld -=1;
        }
    }
    
}
