using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    public float maxSpeed;
    public float rotationSpeed;
    public Vector2 desiredMovement;
    public Vector2 desiredLook;

    private Rigidbody _rigidbody;

    //Tambi�n funcionar�a con Awake, pero puede hacer que al inicio de la partida se para un momento mientras se configura todo
    void OnValidate()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {       

       // GIRAMOS en Y seg�n lo que se mueve el RAT�N
        //Debug.Log(desiredLook);
        Vector3 angularVelocity = new Vector3(0, desiredLook.x, 0);
        // Cuanto m�s r�pido mueves el rat�n, m�s r�pido gira
        _rigidbody.angularVelocity = angularVelocity * rotationSpeed;
        // Normalizado --> Siempre va igual
        //_rigidbody.angularVelocity = angularVelocity.normalized * rotationSpeed;

       // GIRAR LA CABEZA  (ARRIBA Y ABAJO)        

        // MOVIMIENTO DEL PERSONAJE
        /* Mueve hacia delante, no al forward del objeto
            //Para convertir a Vector2
            Vector3 velocity = new Vector3(desiredMovement.x, 0, desiredMovement.y);
            _rigidbody.velocity = velocity * (maxSpeed * Time.fixedDeltaTime);*/

        // Movimiento hacia delante (forward)
        Vector3 forwardVelocity = _rigidbody.transform.forward * desiredMovement.y;
        // Movimiento lateral
        Vector3 strafeVelocity = _rigidbody.transform.right * desiredMovement.x;
        // Sumamos los vectores (normalizados para que no vaya m�s r�pido en diagonal)
        //  -> dar� el vector|direcci�n resultante
        _rigidbody.velocity = (forwardVelocity + strafeVelocity).normalized * (maxSpeed * Time.fixedDeltaTime);
    
    }
}
