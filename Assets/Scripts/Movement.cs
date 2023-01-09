using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    public float maxSpeed;

    public Vector2 desiredMovement;

    private Rigidbody _rigidbody;

    //También funcionaría con Awake, pero puede hacer que al inicio de la partida se para un momento mientras se configura todo
    void OnValidate()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //Para convertir a Vector2
        Vector3 velocity = new Vector3(desiredMovement.x, 0, desiredMovement.y);
        _rigidbody.velocity = velocity * (maxSpeed * Time.fixedDeltaTime);
    }
}
