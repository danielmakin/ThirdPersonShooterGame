using System;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthBar : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset;
    Slider slider;
    public Image[] images;

    private void Start()
    {
        //THE SLIDER IS INITIALISED
        slider = GetComponent<Slider>();
        slider.value = slider.maxValue;
    }
    // Late Update is called after update
    void LateUpdate()
    {
        Vector3 direction = (playerTransform.position - Camera.main.transform.position).normalized;
        bool isBehind = Vector3.Dot(direction, Camera.main.transform.forward) <= 0.0f;
        DisableImages(isBehind);
        //THIS MOVES HE HEALTH BAR
        transform.position = Camera.main.WorldToScreenPoint(playerTransform.position + offset);
    }

    private void DisableImages(bool isBehind)
    {
        foreach (var image in images)
        {
            image.enabled = !isBehind;
        }
    }

    public void SetHealth(float health)
    {
        slider.value = health;
    }

}
