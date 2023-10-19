using UnityEngine;

public class TweenController : MonoBehaviour
{
    public float transTime = 0.1f;

    private void OnEnable()
    {
        CanvasGroup canvas = GetComponent<CanvasGroup>();
        LeanTween.alphaCanvas(canvas, 1, transTime);
    }

    private void OnDisable()
    {
        CanvasGroup canvas = GetComponent<CanvasGroup>();
        LeanTween.alphaCanvas(canvas, 0, transTime);
    }
}
