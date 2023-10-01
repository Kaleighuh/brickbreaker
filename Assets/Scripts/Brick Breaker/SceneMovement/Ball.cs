using UnityEngine;

public class Ball : MonoBehaviour
{
    public new Rigidbody rigidbody { get; private set; }
    public float speed = 500f;

    private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        ResetBall();
    }

    
    public void ResetBall()
    {
        this.transform.position = Vector3.zero;
        this.rigidbody.velocity = Vector3.zero;
        Invoke(nameof(SetRandomTrajectory), 1f);
    }

    private void SetRandomTrajectory()
    {
        Vector3 force = Vector3.zero;
        force.x = Random.Range(-1f, 1f);
        force.z = -1f; // Assuming you want to move the ball in the forward direction in the Z-axis in 3D space.

        this.rigidbody.AddForce(force.normalized * this.speed);
    }
}