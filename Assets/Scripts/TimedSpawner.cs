using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawner : MonoBehaviour
{
    //Lo hacemos con un coolDown para no hacerlo igual que el timeToLive
    public float coolDownTime;
    public GameObject prefabToSpawn;

    private float _heat;

    private void Start()
    {
        _heat = coolDownTime;
    }

    private void Update()
    {
        _heat -= Time.deltaTime;
        if (_heat <= 0)
        {
            Spawn(prefabToSpawn);
            _heat = coolDownTime;
        }
    }

    void Spawn(GameObject prefabToSpawn)
    {
        Instantiate(
            prefabToSpawn,
            transform.position,
            transform.rotation);
    }
}
