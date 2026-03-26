using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    //speed of object
    public float speed = 10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //moves object forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    //detects collision 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Destroys the Player
            Destroy(gameObject);
        }
    }
}
