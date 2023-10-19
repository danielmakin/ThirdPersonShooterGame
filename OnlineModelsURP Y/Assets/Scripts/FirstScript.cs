using UnityEngine;
using System.Collections;

public class FirstScript : MonoBehaviour
{

    private InputActions controls;
    public GameObject menu;
    public Color newColor;
    public float transTime = 0.25f;
    CanvasGroup canvas;

    private void OnEnable()
    {
        controls.Main.Disable();
        controls.PauseScreen.Enable();
        canvas = GetComponent<CanvasGroup>();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
    private void Awake()
    {
        controls = new InputActions();
        controls.PauseScreen.Select.performed += ctx => LoadMenu();
    }

    void LoadMenu()
    {
        LeanTween.alphaCanvas(canvas, 0, transTime);
        StartCoroutine(StartFrame());
    }

    IEnumerator StartFrame()
    {
        yield return new WaitForSeconds(transTime);
        gameObject.SetActive(false);
        menu.SetActive(true);
    }
}
