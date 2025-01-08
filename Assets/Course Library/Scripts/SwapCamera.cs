using UnityEngine;
using UnityEngine.Rendering;

public class SwapCamera : MonoBehaviour
{
    public Camera frontCamera;
    public Camera backCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        frontCamera.enabled = true;
        backCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            frontCamera.enabled = !frontCamera.enabled;
            backCamera.enabled = !backCamera.enabled;
        }
    }
}
