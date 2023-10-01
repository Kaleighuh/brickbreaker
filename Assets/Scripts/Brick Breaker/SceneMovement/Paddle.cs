using UnityEngine;

public class Paddle : MonoBehaviour
{
    public new Rigidbody rigidbody;
    public Vector3 direction;
    public float speed = 30f;
    public float maxBounceAngle = 75f;

    private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody>();
    }

    public void ResetPaddle()
    {
        this.transform.position = new Vector3(0f, this.transform.position.y, 0f);
        this.rigidbody.velocity = Vector3.zero;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.direction = Vector3.left;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.direction = Vector3.right;
        }
        else
        {
            this.direction = Vector3.zero;
        }
    }

    private void FixedUpdate()
    {
        if (this.direction != Vector3.zero)
        {
            this.rigidbody.AddForce(this.direction * this.speed);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            Vector3 paddlePosition = this.transform.position;
            Vector3 contactPoint = collision.contacts[0].point;

            float offset = paddlePosition.x - contactPoint.x;
            float width = collision.collider.bounds.size.x / 2;

            float currentAngle = Vector3.SignedAngle(Vector3.up, ball.rigidbody.velocity, Vector3.forward);
            float bounceAngle = (offset / width) * this.maxBounceAngle;
            float newAngle = Mathf.Clamp(currentAngle + bounceAngle, -this.maxBounceAngle, this.maxBounceAngle);

            Quaternion rotation = Quaternion.AngleAxis(newAngle, Vector3.forward);
            ball.rigidbody.velocity = rotation * Vector3.up * ball.rigidbody.velocity.magnitude;
        }
    }
}