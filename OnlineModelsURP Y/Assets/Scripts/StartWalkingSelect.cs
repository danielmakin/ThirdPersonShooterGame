using UnityEngine;

public class StartWalkingSelect : MonoBehaviour
{
    private InputActions controls;
    public Animator mover;
    public Transform player;
    public Transform masks;
    public float speed;
    private float nextTimeToChange;
    public GameObject character;
    private Transform currentChild;
    int currentChildNum = 0;
    public int noOfCharacters = 2;
    int currentMaskNum = 0;
    Transform currentMask;

    private void Awake()
    {
        controls = new InputActions();
        controls.PauseScreen.Move.performed += ctx => ChangeCharacter(ctx.ReadValue<Vector2>());
        controls.PauseScreen.RBumper.performed += ctx => ChangeMask(Vector2.right);
        controls.PauseScreen.LBumper.performed += ctx => ChangeMask(Vector2.left);
    }
    void ChangeMask(Vector2 move)
    {
        if (move.x > 0.8)
        {
            currentMask.gameObject.SetActive(false);
            currentMaskNum++;
            if (currentMaskNum > masks.childCount - 1)
            {

                currentMaskNum = 0;
            }
            currentMask = masks.GetChild(currentMaskNum);
            currentMask.gameObject.SetActive(true);
        }
        else if (move.x < -0.8f)
        {
            currentMask.gameObject.SetActive(false);
            currentMaskNum--;
            if (currentMaskNum < 0)
            {
                currentMaskNum = masks.childCount - 1;
            }
            currentMask = masks.GetChild(currentMaskNum);
            currentMask.gameObject.SetActive(true);
        }
    }
    void ChangeCharacter(Vector2 move)
    {
        if ((move.x > 0.8) && Time.time > nextTimeToChange)
        {
            currentChild.gameObject.SetActive(false);
            currentChildNum += 1;
            if (currentChildNum == noOfCharacters + 1)
            {
                currentChildNum = 0;
            }
            currentChild = character.transform.GetChild(currentChildNum);
            currentChild.gameObject.SetActive(true);
            mover = currentChild.gameObject.GetComponent<Animator>();
            nextTimeToChange = Time.time + 0.5f;
        }
        else if ((move.x < -0.8) && Time.time > nextTimeToChange)
        {
            currentChild.gameObject.SetActive(false);
            currentChildNum -= 1;
            if (currentChildNum == -1)
            {
                currentChildNum = noOfCharacters;
            }
            currentChild = character.transform.GetChild(currentChildNum);
            currentChild.gameObject.SetActive(true);
            mover = currentChild.gameObject.GetComponent<Animator>();
            nextTimeToChange = Time.time + 0.5f;
        }
    }
    private void OnEnable()
    {
        controls.Enable();
        controls.Main.Disable();
        controls.PauseScreen.Enable();
        currentChild = character.transform.GetChild(0);
        currentMask = masks.GetChild(0);
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
    
    
