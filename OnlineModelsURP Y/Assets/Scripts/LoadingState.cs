using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingState : MonoBehaviour
{
    public Slider slider;
    public void LoadNextScene(int buildIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(buildIndex);
        slider.value = operation.progress;
    }
}
