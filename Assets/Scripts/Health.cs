using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHealth;

    private float _currentHealth;

    private void Start()
    {
        _currentHealth = maxHealth;    
    }

    public void UpdateHealth(float healthChange)
    {
        _currentHealth += healthChange;
        //Rango entre los que puede estar la vida actual    min/max
        _currentHealth = Mathf.Clamp(_currentHealth, 0, maxHealth);

        if (_currentHealth == 0)
            Destroy(gameObject);
    }
}
