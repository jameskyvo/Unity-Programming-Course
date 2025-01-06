using JetBrains.Annotations;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15.0f;
    public float turnSpeed;
    public float horizontalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        // We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
        // We'll turn the vehicle left and right
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}