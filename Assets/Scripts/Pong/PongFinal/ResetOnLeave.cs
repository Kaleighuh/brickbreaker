using UnityEngine;

public class ResetOnLeave : MonoBehaviour

{

    private Vector3 startPosition;

    void Start() {
        startPosition = transform.position;  
    }

    void Update() {
        if (transform.position.x > Screen.width || 
            transform.position.x < 0 ||
            transform.position.y > Screen.height ||
            transform.position.y < 0) {

            transform.position = startPosition;
        }
    }

}