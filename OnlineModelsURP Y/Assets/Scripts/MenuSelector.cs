using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSelector : MonoBehaviour
{
    public List<Button> buttons;
    private InputActions actions;
    public int currentlySelected = 0;
    [SerializeField] private float transTime = 0.25f;

    private void OnEnable()
    {
        GetComponent<CanvasGroup>().alpha = 0f;
        actions.Main.Disable();
        actions.PauseScreen.Enable();
        LeanTween.alphaCanvas(GetComponent<CanvasGroup>(), 1, transTime);
        SelectButton();
    }
    private void Awake()
    {
        actions = new InputActions();
        actions.PauseScreen.RBumper.performed += ctx => MoveRight();
        actions.PauseScreen.LBumper.performed += ctx => MoveLeft();
    }
    public void MoveRight()
    {
        if (currentlySelected == buttons.Count - 1)
        {
            currentlySelected = 0;
        }
        else
        {
            currentlySelected++;
        }
        SelectButton();
    }
    public void MoveLeft()
    {
        if (currentlySelected == 0)
        {
            currentlySelected = buttons.Count - 1;
        }
        else
        {
            currentlySelected--;
        }
        SelectButton();
    }
    private void SelectButton() 
    {
        buttons[currentlySelected].onClick.Invoke();
        buttons[currentlySelected].Select();
    }
}
