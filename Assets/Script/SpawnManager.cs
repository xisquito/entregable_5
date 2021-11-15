using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    // private Vector3 spawnPos = (0, 0, 30);
    private float randomY;



    // Start is called before the first frame update
    void Start()
    {
        randomY = Random.Range(-10, 11);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
