using System.Collections;

using System.Collections.Generic;
using Unity.VisualScripting;
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
    public float maxSpeed;
    public float stickForce = 20f;
    private Vector3 currentVelocity;
    public GravityAttractor gravityAttractor = null;


    void FixedUpdate()
    {
        direction = move.action.ReadValue<Vector2>();
          //    currentVelocity = Vector3.SmoothDamp(currentVelocity, new Vector3(direction.x, 0 ,direction.y)  * speed, ref smoothMoveVelocity, smoothTime);
    Vector3 dir = new Vector3(direction.x, 0f,direction.y);
        //rb.linearVelocity = currentVelocity * speed;
         rb.linearDamping = (speed / maxSpeed);
        rb.AddRelativeForce(dir* speed);
            rb.AddForce(gravityAttractor.up * stickForce, ForceMode.Acceleration);
    }
    

    void onMove(InputValue inputValue)
    {
        Debug.Log(inputValue.Get<Vector2>());
    }

    
}