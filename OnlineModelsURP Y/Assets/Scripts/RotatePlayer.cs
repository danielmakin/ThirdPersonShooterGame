using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    public Transform newCam;
    public float turnSpeed = 15f;
    float mainCam;
    private void FixedUpdate()
    { 
        mainCam = newCam.rotation.eulerAngles.y;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, mainCam, 0), turnSpeed * Time.fixedDeltaTime);
    }
}
