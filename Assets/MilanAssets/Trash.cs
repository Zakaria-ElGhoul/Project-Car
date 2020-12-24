using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour, IPooledObject
{
    public Rigidbody rigidB;

    //snelheid waarmee hij word afgeschoten
    public float minForce, maxForce;

    //functie wordt gestart wanneer hij word afgeschoten
    public void OnObjectSpawn()
    {
        //reset rigidbody
        rigidB.velocity = new Vector3(Random.Range(minForce, maxForce), 0, 0);
    }
}
