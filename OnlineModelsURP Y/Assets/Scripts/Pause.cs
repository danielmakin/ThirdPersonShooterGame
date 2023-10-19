using UnityEngine;

public class Pause : MonoBehaviour
{
    InputActions controls;
    bool paused = false;
    public GameObject pauseScreen;

    private void Awake()
    {
        controls = new InputActions();
        controls.Main.Pause.performed += ctx => PauseGame();
        controls.PauseScreen.UnPause.performed += ctx => PauseGame();
    }
    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }
    public void PauseGame()
    {
        paused = !paused;
        pauseScreen.SetActive(paused);
        if (paused)
        {
            Time.timeScale = 0;
            controls.Main.Disable();
            controls.PauseScreen.Enable();
        }
        else
        {
            Time.timeScale = 1;
            controls.Main.Enable();
            controls.PauseScreen.Disable();
        }
    }
}
