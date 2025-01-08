using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 25.0f;
    public float horizontalInput;
    public float verticalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("P2Horizontal");
        verticalInput = Input.GetAxis("P2Vertical");

        // We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // We'll turn the vehicle left and right
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
