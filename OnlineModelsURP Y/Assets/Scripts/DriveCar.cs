using System.Threading;
using UnityEngine;

public class DriveCar : MonoBehaviour
{
    public Transform waypoint;
    public Transform doors;
    public float transTime = 3f;
    public float wheelSpeed = 5f;
    public Transform[] wheels;
    private void OnEnable()
    {
        Move();
    }

    void Move()
    {
        Vector3 startPos = transform.position;
        LeanTween.value(startPos.x, waypoint.position.x, transTime).setOnUpdate((float val) =>
        {
            transform.position = new Vector3(val, transform.position.y, transform.position.z);
        });

        LeanTween.value(0, 360f * wheelSpeed, transTime).setOnUpdate((float val) =>
        {
            for (int i = 0; i < wheels.Length - 1; i++)
            {
                wheels[i].localRotation = Quaternion.Euler(val, 0, 0);
            }
        });
    }
}
