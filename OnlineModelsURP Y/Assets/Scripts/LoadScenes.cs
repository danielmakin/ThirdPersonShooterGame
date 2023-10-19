using UnityEngine;
using System.IO;
using TMPro;
using System.Collections;

public class LoadScenes : MonoBehaviour
{
    private InputActions actions;
    public GameObject loading;
    public LoadingState state;
    public GameObject panel;

    [SerializeField] private CanvasGroup changeNameOption;
    [SerializeField] private CanvasGroup changeNameText;
    [SerializeField] private TextMeshProUGUI changeText;

    
    public void LoadNextSceneAndShowSlider(int buildIndex)
    {
        panel.SetActive(false);
        loading.SetActive(true);
        state.LoadNextScene(buildIndex);

    }
}
