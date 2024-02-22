using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ObstaclePrefab;
    private Vector3 spawnPosition = new Vector3(20, 0, 0);
    private float starDelay = 2f;
    private float repeatRate = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", starDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        Instantiate(ObstaclePrefab, spawnPosition, ObstaclePrefab.transform.rotation);
    }
}
