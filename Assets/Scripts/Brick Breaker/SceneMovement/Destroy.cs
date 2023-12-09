using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour 
{

    void OnCollisionEnter(Collision collision) 
    {
        DestroyObject(collision.gameObject);
    }

    void DestroyObject(GameObject obj) 
    {
        if (IsDestroyable(obj)) {
            Destroy(obj);
            GivePoints();
        }
    }

    bool IsDestroyable(GameObject obj) 
    {
        // Check if object meets destroyable criteria 
        // E.g. layer mask, component, object name

        return destroyableObjects.Contains(obj); 
    }

    void GivePoints() 
    {
        score += 10;
    }
}
