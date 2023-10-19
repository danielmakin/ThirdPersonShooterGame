using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menus : MonoBehaviour
{
    private InputActions actions;
    public List<GameObject> screens;
    private int selected = 0;
    [Range(0.5f, 1)]
    public float sens;
    public float transTime = 0.1f;
    float nextTimeToChange = 0f;
    public float changeDelay = 0.5f;
    public Color grey;
    public Color white;
    public MenuSelector tabs;

    bool changeTab = false;
    
    private void OnEnable()
    {
        selected = 0;
        actions.Main.Disable();
        actions.PauseScreen.Enable();
        Select();
        changeTab = false;
    }
    private void OnDisable()
    {
        Deselct();
        actions.Main.Disable();
        actions.PauseScreen.Disable();
    }
    private void Awake()
    {
        actions = new InputActions();
        actions.PauseScreen.Move.performed += ctx => Move(ctx.ReadValue<Vector2>());
        actions.PauseScreen.Select.performed += ctx => DoSomething();

        //actions.PauseScreen.Right.performed += ctx => Move(Vector2.right);
        //actions.PauseScreen.Left.performed += ctx => Move(Vector2.left);
    }
    void DoSomething()
    {
        screens[selected].GetComponent<Button>().onClick.Invoke();
    }
    void Move(Vector2 move)
    {
        if (move.x > sens && Time.time > nextTimeToChange)
        {
            Deselct();
            if (selected == screens.Count - 1)
            {
                tabs.MoveRight();
                changeTab = true;
            }
            else
            {
                selected++;
            }
            if (!changeTab)
            {
                Select();
            }
            
            nextTimeToChange = Time.time + changeDelay;
        }else if (move.x < -sens && Time.time > nextTimeToChange)
        {
            Deselct();
            if (selected == 0)
            {
                tabs.MoveLeft();
                changeTab = true;
            }
            else
            {
                selected--;
            }
            if (!changeTab)
            {
                Select();
            }
            
            nextTimeToChange = Time.time + changeDelay;
        }
    }
    void Select()
    {
        screens[selected].GetComponent<Image>().color = grey;
        LayoutElement element = screens[selected].GetComponent<LayoutElement>();
        LeanTween.value(gameObject, 0, 30, transTime).setOnUpdate((float val) =>
        {
            element.preferredWidth = val;
        });
    }
    void Deselct()
    {
        screens[selected].GetComponent<Image>().color = white;
        LayoutElement element = screens[selected].GetComponent<LayoutElement>();
        element.preferredWidth = 0;
    }

    
}
