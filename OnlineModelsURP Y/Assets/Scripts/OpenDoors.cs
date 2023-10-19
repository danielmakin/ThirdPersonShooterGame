using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoors : MonoBehaviour
{
    public GameObject oneDoor;
    public GameObject otherDoor;
    public float transTime = 0.5f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            OpenDoorsNow(0, -90f);
        }
    }

    void OpenDoorsNow(float from, float to)
    {
        LeanTween.value(oneDoor, from, to, transTime).setOnUpdate((float val) =>
        {
            oneDoor.transform.eulerAngles = new Vector3(0, val, 0);
            Debug.Log(val);
        });

        LeanTween.value(oneDoor, -from, -to, transTime).setOnUpdate((float val) =>
        {
            otherDoor.transform.eulerAngles = new Vector3(0, val, 0);
        });
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            OpenDoorsNow(-90f, 0);
        }
    }
}
