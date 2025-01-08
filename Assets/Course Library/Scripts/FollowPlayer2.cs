using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{
    public Camera frontCamera;
    public Camera backCamera;
    private Vector3 frontOffset = new Vector3(0, 6, -18);
    private Vector3 backOffset = new Vector3(0, 4, 3);
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        frontCamera.transform.position = player.transform.position + frontOffset;
        backCamera.transform.position = player.transform.position + backOffset;
    }
}
