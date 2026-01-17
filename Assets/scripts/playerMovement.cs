using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.InputSystem;


public class playerMovement : MonoBehaviour

{
    public InputActionReference move;
    public CharacterController character;
    public Vector2 direction;
    public float speed = 5;
    void Update()
    {
        direction = move.action.ReadValue<Vector2>();
        character.Move(direction * Time.deltaTime * speed);
    }

    void onMove(InputValue inputValue)
    {
        Debug.Log(inputValue.Get<Vector2>());
    }

    
}