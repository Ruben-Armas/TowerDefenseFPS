using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    public Rigidbody _rigidbody;

    /*Si lo pongo en el FixedUpdate estaría siempre aplicando esa velocidad
     * por lo que no caería por la gravedad
     * Pero si lo hago en el Start() -> tendremos balas con caida
    */ 
    public void Start()
    {//No hace falta el deltaTime porque solo se usa cuando "se suma"
        _rigidbody.velocity = transform.forward * speed;
    }

}
