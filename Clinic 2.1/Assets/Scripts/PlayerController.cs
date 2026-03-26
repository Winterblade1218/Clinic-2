using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Speed of player
    public float speed = 10.0f;

    // Speed of lane switching
    public float moveSpeed = 10.0f;

    // Distance between lanes
    public float laneDistance = 3f;

    // Current lane
    private int targetLane = 1;

    // Brings in player rigidbody
    private Rigidbody playerRb;

    // How far player jumps
    public float jumpForce = 10;

    // The strength of gravity
    public float gravityModifier;

    // Variable for if player is on ground or not
    public bool isOnGround = true;

    // Slide force? Hopefully.
    public float downForce = 10;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // gets the players rigidbody
       playerRb = GetComponent<Rigidbody>(); 
       Physics.gravity *= gravityModifier; 
    }

    // Update is called once per frame
    void Update()
    {
        // Moves Player Forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //Input for lane switching
        if (Input.GetKeyDown(KeyCode.LeftArrow) && targetLane > 0)
        {
            targetLane--;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && targetLane < 2)
        {
            targetLane++;
        }

        //Calculate Position
        Vector3 targetPosition = new Vector3((targetLane - 1) * laneDistance, transform.position.y, transform.position.z);

        //Move to Lane
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * moveSpeed);

        //Jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

        //Slide
       // if (Input.GetKeyDown(KeyCode.DownArrow) && isOnGround)
       // {
           // playerRb.AddForce(Vector3.down * downForce, ForceMode.Impulse);
            //isOnGround = false;
        //}
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Dectects if player is on ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
