using UnityEngine;
using System.Collections;

public class CropCode : MonoBehaviour
{
    private PlayerController playerController;
    public float Countdown;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        Countdown+=1;

        if (Countdown == 2000)
        {
            playerController.isAlive+=1;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (playerController.haveWater == true)
            {
                Countdown-=2000;
                Debug.Log("plant has been watered");
                playerController.haveWater = false;
            }
        }
    }
}
