using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyOnCollision : MonoBehaviour 
{
    public GameObject[] objectsToDestroy;  
    public Text scoreText;

    int score = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (objectsToDestroy != null) {

            foreach (GameObject obj in objectsToDestroy) {

                if (obj != null && collision.gameObject == obj) {

                    Destroy(obj);

                    if (scoreText != null) { 
                        score += 10;
                        scoreText.text = "Score: " + score;
                    }
                }
            }   
        }
    }
}
