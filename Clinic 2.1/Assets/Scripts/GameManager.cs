using UnityEngine;

public class GameManager : MonoBehaviour
{   
    //Brings in the obstacle prefab
    public GameObject obstaclePrefab;

    //private Vector3 spawnPos = new Vector3(0, 1, 60);

    // delay before start
    private float startDelay = 2;

    // delay before repeats
    private float repeatRate = 2;

    //list of spawn points
    public Transform[] spawnPoints;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //repeated spawns obstacles 
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //spawns obstacle 
    void SpawnObstacle()
    {
        // chooses randomly from the list of spawnpoints
        Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

        // spawns the obstacle at spawn point
        Instantiate(obstaclePrefab, spawnPoint.position,spawnPoint.rotation);
    }
}
