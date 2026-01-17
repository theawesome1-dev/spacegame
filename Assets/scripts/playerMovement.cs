using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.InputSystem;


public class playerMovement : MonoBehaviour

{
    public InputActionReference move;
    public Rigidbody rb;
    public Vector2 direction;
    private Vector3 smoothMoveVelocity;
    public float smoothTime = 0.1f;
    public float speed = 5;
    private Vector3 currentVelocity;
    void Update()
    {
        direction = move.action.ReadValue<Vector2>();
              currentVelocity = Vector3.SmoothDamp(currentVelocity, new Vector3(direction.x, 0 ,direction.y)  * speed, ref smoothMoveVelocity, smoothTime);

        rb.linearVelocity = currentVelocity * speed;
    }

    void onMove(InputValue inputValue)
    {
        Debug.Log(inputValue.Get<Vector2>());
    }

    
}