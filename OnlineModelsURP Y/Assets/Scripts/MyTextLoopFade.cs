using UnityEngine;
using TMPro;

public class TextLoopFade : MonoBehaviour
{
    public float transTime = 0.2f;
    public Color color;
    public TextMeshProUGUI text;
    private void OnEnable()
    {
        LeanTween.value(gameObject, 0, 1, transTime).setLoopPingPong().setOnUpdate((float val) =>
        {
            color.a = val;
            text.color = color;
        });
    }
}
