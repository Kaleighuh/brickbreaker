using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectiveCollision : MonoBehaviour {

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Ball Layer")) {
            // Code here to handle collision with balls
        } 
    }

    void OnCollisionStay(Collision collision) {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Ball Layer")) {
            // Code here to handle ongoing collision with balls 
        }
    }

    void OnCollisionExit(Collision collision) {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Ball Layer")) {
            // Code here to handle end of collision with balls
        }
    }

}
