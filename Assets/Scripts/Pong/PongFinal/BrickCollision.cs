using UnityEngine;

public class BrickCollision : MonoBehaviour
{
    public LayerMask ballLayer;
    public LayerMask wallLayer;

    private Collider collider;

    void Start()
    {
        collider = GetComponent<Collider>();    
    }

    void OnCollisionEnter(Collision collision)
    {
        if ((ballLayer.value & 1 << collision.gameObject.layer) > 0)
        {
            // Collision with ball layer, enable collider
            //collider.isTrigger = false;
        }
        
        if ((wallLayer.value & 1 << collision.gameObject.layer) > 0)
        {
            // Collision with wall layer, disable collider 
            //collider.isTrigger = false;
        }
    }
}