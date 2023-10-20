using UnityEngine;

public class PongPlayerPaddle : PongPaddle
{
   private Vector3 _direction;
   

   private void Update()
   {
      if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
      {
         _direction = Vector3.up;
      }
      else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
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
