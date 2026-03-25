using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(0, 1, 60);
    private float startDelay = 2;
    private float repeatRate = 2;

     public Transform[] spawnPoints;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
        Instantiate(obstaclePrefab, spawnPoint.position,spawnPoint.rotation);
    }
}
