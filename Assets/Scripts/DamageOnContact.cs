using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnContact : MonoBehaviour
{
    public float damage;
    public bool destroyOnContact;
    public GameObject FXOnContact;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Hit {collision.gameObject.name} whit {damage}");

        Health health = collision.gameObject.GetComponent<Health>();
        //Forma 1
        if(health!= null)
        {
            health.UpdateHealth(-damage);
        }
        /*Forma 2   - Permite llamar fuera, lo que se ha creado dentro de la funci�n
        //y si no existe, fallar� fuera y no indicar� el fallo
        if (collision.gameObject.TryGetComponent(out Health h)) {}*/

        Instantiate(FXOnContact, collision.gameObject.transform.position, Quaternion.identity);
        if (destroyOnContact)
            Destroy(gameObject);
    }
}
