using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] cropPrefab;
    public Transform[] waterspawnPoints;
    public GameObject[] waterPrefab;
    private float startDelay = 1;
    private float repeatRate = 3.3f;
    public GameObject Player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SpawnCrop();
        InvokeRepeating("SpawnWater", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void SpawnCrop()
   // {
      //  Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
      //  int cropIndex = Random.Range(0, cropPrefab.Length);
      //  Instantiate(cropPrefab[cropIndex], spawnPoint.position, spawnPoint.rotation);
  //  }

     void SpawnWater()
    {
        if (Player != null)
        {
            Transform waterspawnPoint = waterspawnPoints[Random.Range(0, waterspawnPoints.Length)];
            int waterIndex = Random.Range(0, waterPrefab.Length);
            Instantiate(waterPrefab[waterIndex], waterspawnPoint.position, waterspawnPoint.rotation);
        }
    }

}
