using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandmiseMovement : MonoBehaviour
{
    [SerializeField]
    private Vector2 min;
    [SerializeField]
    private Vector2 max;
    [SerializeField]
    private Vector2 yRotationChange;
    [SerializeField]
    [Range(0, 0.1f)]
    private float lerpSpeed = 0.05f;
    Vector3 _newPosition;
    Quaternion _newRotation;

    void Awake()
    {
        _newPosition = transform.position;
        _newRotation = transform.rotation;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _newPosition, Time.deltaTime * lerpSpeed);
        transform.rotation = Quaternion.Lerp(transform.rotation, _newRotation, Time.deltaTime * lerpSpeed);

        if (Vector3.Distance(transform.position, _newPosition) < 1f)
        {
            GetNewPosition();
        }
    }
    void GetNewPosition()
    {
        var xPos = Random.Range(min.x, max.x);
        var yPos = Random.Range(min.y, max.y);
        _newRotation = Quaternion.Euler(transform.rotation.eulerAngles.y, Random.Range(yRotationChange.x, yRotationChange.y), transform.eulerAngles.z);
        _newPosition = new Vector3(xPos, transform.position.y, yPos);
    }
}
