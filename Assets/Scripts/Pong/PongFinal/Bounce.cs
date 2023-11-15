using UnityEngine;

public class Bounce : MonoBehaviour 
{

    public float bounceStrength = 10f;
  
    void OnCollisionEnter(Collision collision) {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

        if (rb != null) {
            Vector3 direction = collision.contacts[0].point - transform.position;
            rb.AddForce(direction.normalized * bounceStrength, ForceMode.Impulse);
        }
    }

}