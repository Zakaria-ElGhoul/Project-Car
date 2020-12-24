using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    ObjectPooler objectPooler;

    public float spawnSpeed;
    private float nexTimeToSpawn = 0f;
    [Space]
    //locatie waar hij gespawnt wordt op X en Y as
    public float minX, maxX;
    public float minZ, maxZ;

    void Start()
    {
        objectPooler = ObjectPooler.Instance;
    }

    void FixedUpdate()
    {
        if(Time.time >= nexTimeToSpawn)
        {
            Vector3 spawnLocation = new Vector3(Random.Range(maxX,minX),0 ,Random.Range(maxZ, minZ));

            nexTimeToSpawn = Time.time + 1f / spawnSpeed;
            objectPooler.SpawnFromPool("Cube", spawnLocation, Quaternion.identity);
        }
    }
}
