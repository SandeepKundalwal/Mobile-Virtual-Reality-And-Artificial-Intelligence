using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public bool isOnGround;
    private Rigidbody cubeRB;
    public float rotationSpeed;
    private float forwardInput;
    
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 15f;
        jumpForce = 10f;
        isOnGround = true;
        rotationSpeed = 20f;
        cubeRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // get cube input
        forwardInput = Input.GetAxis("Vertical");

        // on click of UpArrow, move towards the facing direction
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.back * moveSpeed * forwardInput * Time.deltaTime);
        }

        // on click of DownArrow, move opposite to the facing direction
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * moveSpeed * forwardInput * Time.deltaTime);
        }

        // on click of LeftArrow, rotate Anti-Clockwise
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(transform.position, -Vector3.up, rotationSpeed * Time.deltaTime);
        }

        // on click of RightArrow, rotate Clockwise
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(transform.position, Vector3.up, rotationSpeed * Time.deltaTime);
        }

        // jump the cube
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            cubeRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
