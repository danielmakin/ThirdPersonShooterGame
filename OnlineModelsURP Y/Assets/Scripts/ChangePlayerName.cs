using System.Collections;
using UnityEngine;

public class ChangePlayerName : MonoBehaviour
{
    [SerializeField] CanvasGroup changeNameText;
    [SerializeField] CanvasGroup changeNameOption;


    IEnumerator TurnCanvasOff(CanvasGroup group)
    {
        yield return new WaitForSeconds(0.10f);
        group.gameObject.SetActive(false);
        changeNameText.gameObject.SetActive(true);
    }

    public void ChangeName()
    {
        LeanTween.alphaCanvas(changeNameOption, 0, 0.10f);

        StartCoroutine(TurnCanvasOff(changeNameOption));
    }
}
