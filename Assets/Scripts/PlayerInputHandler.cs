using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Movement))]
public class PlayerInputHandler : MonoBehaviour
{
    private Movement _movement;

    private void OnValidate()
    {
        _movement = GetComponent<Movement>();
    }

    public void OnFire(InputValue value)
    {
        Debug.Log("PewPew");
    }

    public void OnMove(InputValue value)
    {
        Vector2 movement = value.Get<Vector2>();
        _movement.desiredMovement = movement;
        //Debug.Log($"Walk{direction}");
    }

}
