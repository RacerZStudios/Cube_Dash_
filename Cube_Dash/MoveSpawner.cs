using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpawner : MonoBehaviour
{
    public float speed;
    public GameObject[] objs;
    public Transform[] objSpawns; 

    private void Start()
    {
        while(gameObject != null)
        {
            StartCoroutine(SpawnWave());
            break; 
        }

        InvokeRepeating("Wave1", 3, 4); 
    }

    public IEnumerator SpawnWave()
    {
        yield return new WaitForSeconds(Random.Range(0, 3));
        Wave1(); 
    }

    void SpawnWave1()
    {
        GameObject g = objs[Random.Range(0, objs.Length)]; 
        Instantiate(g, objSpawns[0].position, objSpawns[0].rotation);
        Instantiate(g, objSpawns[1].position, objSpawns[1].rotation);
        Instantiate(g, objSpawns[2].position, objSpawns[2].rotation);
    }

    void Wave1()
    {
        SpawnWave1(); 
        transform.position += -transform.forward * 3.25f; 
    }
}
