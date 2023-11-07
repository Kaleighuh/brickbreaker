using UnityEngine;

//code borrowed and modified by Zigurous on youtube https://www.youtube.com/watch?v=RYG8UExRkhA
public class RightPlayerPongPaddle : MonoBehaviour

{
    public new Rigidbody rigidbody {get; private set;}
    public Vector2 direction {get; private set;}
    public float speed = 30f;
    public float maxBounceAngle = 60f;
    private Vector3 startPos;

    private void Awake()
    {
        this.rigidbody = this.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.direction = Vector3.up;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.direction = Vector3.down;
        }
        else
        {
            this.direction = Vector3.zero;
        }
    }

    private void FixedUpdate()
    {
        if (this.direction != Vector2.zero)
        {
            this.rigidbody.AddForce(this.direction * this.speed);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        PongBall ball = collision.gameObject.GetComponent<PongBall>();

        if (ball != null)
        {
            Vector3 paddlePosition = this.transform.position;
            Vector3 contactPoint = collision.GetContact(0).point;

            float offset = paddlePosition.x - contactPoint.x;
            float width = collision.collider.bounds.size.x / 2;

            float currentAngle = Vector2.SignedAngle(Vector2.up, ball.GetComponent<Rigidbody>().velocity);
            float bounceAngle = (offset / width) * this.maxBounceAngle;
            float newAngle = Mathf.Clamp(currentAngle + bounceAngle, -this.maxBounceAngle, this.maxBounceAngle);

            Quaternion rotation = Quaternion.AngleAxis(newAngle, Vector3.forward);

            ball.GetComponent<Rigidbody>().velocity = rotation * Vector3.up * ball.GetComponent<Rigidbody>().velocity.magnitude;
        }
    }
    
    public void ResetToZero()
    {
        startPos = new Vector3(0f, 1.55f, 0f);
        transform.position = startPos;
    }
}