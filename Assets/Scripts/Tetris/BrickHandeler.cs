using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BrickHandeler : MonoBehaviour
{
    public UnityEvent destroyEvent;
    public GameObject destroyerObject;
    
    void OnCollisionEnter()
    {
        //spawnerStats.CubeDestroyed();
        if (gameObject == destroyerObject)
        {
            destroyEvent.Invoke();
            Debug.Log("Destroy");
            //Destroy(gameObject);
        }
    }
}
