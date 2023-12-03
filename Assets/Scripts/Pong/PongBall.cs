using UnityEngine;

public class PongBall : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float speed = 200.00f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        //_rigidbody.bounciness = 1.0f;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Destroyable"))
        {
            Destroy(other.gameObject);
        }
    }
    private void Start()
    {
        AddStartingForce();
    }

    private void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        Vector3 direction = new Vector3(x, y);
        _rigidbody.AddForce(direction * this.speed);
    }
    
    
}

