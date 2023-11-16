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
        if (Input.GetKey(KeyCode.I))
        {
            this.direction = Vector3.up;
        }
        else if (Input.GetKey(KeyCode.K))
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
    
    public void ResetToZero()
    {
        startPos = new Vector3(0f, 1.55f, 0f);
        transform.position = startPos;
    }
}