using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float horizontalInput;
    public float forwardInput;
    public bool haveWater;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        haveWater = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        position.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.position = position;
    }
}
