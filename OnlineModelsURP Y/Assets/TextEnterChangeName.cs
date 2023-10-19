using UnityEngine;
using TMPro;
using System.IO;

public class TextEnterChangeName : MonoBehaviour
{
    private InputActions actions;
    [SerializeField] TextMeshProUGUI textBox;
    private void OnEnable()
    {
        actions.Enable();
        actions.Main.Disable();
        actions.PopUp.Disable();
        actions.PauseScreen.Disable();
        actions.KeyBoard.Enable();
        string path = Application.persistentDataPath + "/player.name";
        if (File.Exists(path))
        {
            string text = SavePlayer.LoadName();
            textBox.text = text;
        }
        else
        {
            textBox.text = "";
        }

        LeanTween.alphaCanvas(GetComponent<CanvasGroup>(), 1, 0.10f);
    }

    private void Awake()
    {
        actions = new InputActions();
        //actions.KeyBoard.Q.performed += ctx => ChangeName("Q");
        //actions.KeyBoard.W.performed += ctx => ChangeName("W");
        //actions.KeyBoard.E.performed += ctx => ChangeName("E");
        //actions.KeyBoard.T.performed += ctx => ChangeName("Q");
        //actions.KeyBoard.Q.performed += ctx => ChangeName("Q");
        //actions.KeyBoard.Q.performed += ctx => ChangeName("Q");
        //actions.KeyBoard.Q.performed += ctx => ChangeName("Q");
        //actions.KeyBoard.Q.performed += ctx => ChangeName("Q");
        //actions.KeyBoard.Q.performed += ctx => ChangeName("Q");
        //actions.KeyBoard.Q.performed += ctx => ChangeName("Q");
    }

    void ChangeName(string code)
    {
        string textChange = textBox.text + code.ToString();
        textBox.text = textChange;
    }
}
