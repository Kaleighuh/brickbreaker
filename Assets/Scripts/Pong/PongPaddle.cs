using UnityEngine;

public class PongPaddle : MonoBehaviour
{
   public float speed = 10.0f;
   protected Rigidbody _rigidbody;

   private void Awake()
   {
      _rigidbody = GetComponent<Rigidbody>();
   }
}
