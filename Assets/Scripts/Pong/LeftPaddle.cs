using UnityEngine;

public class LeftPaddle : PongPaddle
{
    private Vector3 _direction;
   

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _direction = Vector3.up;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _direction = Vector3.down;
        }
        else
        {
            _direction = Vector3.zero;
        }
    }

    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(_direction * this.speed);
        }
    }
}