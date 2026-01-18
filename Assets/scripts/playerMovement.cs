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

    public Animator _animator;


    void FixedUpdate()
    {
        direction = move.action.ReadValue<Vector2>();
        
        Vector3 dir = new Vector3(direction.x, 0f,direction.y);
        
        //animate
        if (direction.x > 0)
        {
            _animator.SetBool("isWalkingRight", true);
            _animator.SetBool("isWalkingLeft", false);
        }
        else if (direction.x < 0)
        {
            _animator.SetBool("isWalkingLeft", true);
            _animator.SetBool("isWalkingRight", false);
        }
        else
        {
            _animator.SetBool("isWalkingLeft", false);
            _animator.SetBool("isWalkingRight", false);
        }
        if (direction.y > 0)
        {
            _animator.SetBool("isWalkingBack", true);
            _animator.SetBool("isWalkingForward", false);
        }
        else if (direction.y < 0)
        {
            _animator.SetBool("isWalkingForward", true);
            _animator.SetBool("isWalkingBack", false);
        }
        else
        {
            _animator.SetBool("isWalkingBack", false);
            _animator.SetBool("isWalkingForward", false);
        }

        if (!(rb.position.z <= -8.5 && direction.y < 0  || rb.position.z >= 8.5 && direction.y > 0))
        {
            rb.linearDamping = (speed / maxSpeed);
            rb.AddRelativeForce(dir* speed);
            rb.AddForce(gravityAttractor.up * stickForce, ForceMode.Acceleration);
        }
    }
    

    void onMove(InputValue inputValue)
    {
        Debug.Log(inputValue.Get<Vector2>());
    }
}