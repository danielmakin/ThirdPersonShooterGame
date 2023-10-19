using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class HeistCharacterSelect : MonoBehaviour
{
    public Transform masks;
    InputActions actions;
    int currentMask = 2;
    int currentGFX = 0;
    public int maxGFX = 7;
    public float sensitivity = 0.8f;
    float nextTimeToChange = 0f;
    public float changeRate = 0.4f;
    public Vector2 move;
    bool saved = false;
    public GameObject popUp;
    public GameObject heistExplain;
    bool firstTime = false;
    public LoadingState state;
    public GameObject loadingPanel;


    private void Start()
    {
        actions.PauseScreen.Enable();
        actions.Main.Disable();
        saved = true;
        FileExist();
    }

    void FileExist()
    {
        string path = Application.persistentDataPath + "/player.gfx";
        if (File.Exists(path))
        {
            RevertToOldChoice();
        }
        else
        {
            heistExplain.SetActive(true);
            actions.Main.Disable();
            actions.PopUp.Enable();
            actions.PauseScreen.Disable();
            firstTime = true;
        }
    }

    private void Awake()
    {
        actions = new InputActions();
        actions.PauseScreen.RBumper.performed += ctx => ChangeMask(Vector2.right);
        actions.PauseScreen.LBumper.performed += ctx => ChangeMask(Vector2.left);

        actions.PauseScreen.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        actions.PauseScreen.Move.canceled += ctx => move = Vector2.zero;

        actions.PauseScreen.Select.performed += ctx => SavePlayerChoice();
        actions.PauseScreen.Back.performed += ctx => CheckIfSaved();

        actions.PopUp.Back.performed += ctx => LoadMainMenu();
        actions.PopUp.Select.performed += ctx => SavePlayerChoice();
    }

    void LoadMainMenu()
    {
        if (!firstTime)
        {
            popUp.SetActive(false);
            loadingPanel.SetActive(true);
            state.LoadNextScene(0);
        }
    }
    void SavePlayerChoice()
    {
        if (!firstTime)
        {
            PlayerData data = new PlayerData(currentGFX, currentMask);
            SavePlayer.SaveSystem(data);
            saved = true;
            popUp.SetActive(false);
            loadingPanel.SetActive(true);
            state.LoadNextScene(0);
        }
        else
        {
            LeanTween.alphaCanvas(heistExplain.GetComponent<CanvasGroup>(), 0, 0.2f);
            actions.PopUp.Disable();
            actions.PauseScreen.Enable();
            firstTime = false;
        }
        
    }

    void CheckIfSaved()
    {
        actions.PauseScreen.Disable();
        actions.PopUp.Enable();
        if (!saved)
        {
            popUp.SetActive(true);
            LeanTween.alphaCanvas(popUp.GetComponent<CanvasGroup>(), 1, 0.4f);
        }
    }

    void RevertToOldChoice()
    {
        PlayerData data = SavePlayer.LoadPlayer();
        masks.GetChild(currentMask).gameObject.SetActive(false);
        transform.GetChild(currentGFX).gameObject.SetActive(false);

        currentGFX = data.GFX;
        currentMask = data.mask;

        transform.GetChild(currentGFX).gameObject.SetActive(true);
        masks.GetChild(currentMask).gameObject.SetActive(true);


        if (masks.GetChild(currentMask).gameObject.tag == "EditorOnly")
        {
            if (transform.GetChild(currentGFX).gameObject.tag == "Shootable")
            {
                masks.GetChild(1).gameObject.SetActive(true);
                masks.GetChild(0).gameObject.SetActive(false);
            }
            else
            {
                masks.GetChild(0).gameObject.SetActive(true);
                masks.GetChild(1).gameObject.SetActive(false);
            }
        }
        else
        {
            masks.GetChild(0).gameObject.SetActive(false);
            masks.GetChild(1).gameObject.SetActive(false);
        }


    }

    void FixedUpdate()
    {
        if (Time.time > nextTimeToChange)
        {
            if (move.x < -sensitivity)
            {
                saved = false;
                transform.GetChild(currentGFX).gameObject.SetActive(false);
                currentGFX--;
                if (currentGFX == -1)
                {
                    currentGFX = maxGFX - 1;
                }
                transform.GetChild(currentGFX).gameObject.SetActive(true);
                nextTimeToChange = Time.time + changeRate;

                if (masks.GetChild(currentMask).gameObject.tag == "EditorOnly")
                {
                    if (transform.GetChild(currentGFX).gameObject.tag == "Shootable")
                    {
                        masks.GetChild(1).gameObject.SetActive(true);
                        masks.GetChild(0).gameObject.SetActive(false);
                    }
                    else
                    {
                        masks.GetChild(0).gameObject.SetActive(true);
                        masks.GetChild(1).gameObject.SetActive(false);
                    }
                }
                else
                {
                    masks.GetChild(0).gameObject.SetActive(false);
                    masks.GetChild(1).gameObject.SetActive(false);
                }
            }
            else if (move.x > sensitivity)
            {
                saved = false;
                transform.GetChild(currentGFX).gameObject.SetActive(false);
                currentGFX++;
                if (currentGFX == maxGFX)
                {
                    currentGFX = 0;
                }
                transform.GetChild(currentGFX).gameObject.SetActive(true);
                nextTimeToChange = Time.time + changeRate;

                if (masks.GetChild(currentMask).gameObject.tag == "EditorOnly")
                {
                    if (transform.GetChild(currentGFX).gameObject.tag == "Shootable")
                    {
                        masks.GetChild(1).gameObject.SetActive(true);
                        masks.GetChild(0).gameObject.SetActive(false);
                    }
                    else
                    {
                        masks.GetChild(0).gameObject.SetActive(true);
                        masks.GetChild(1).gameObject.SetActive(false);
                    }
                }
                else
                {
                    masks.GetChild(0).gameObject.SetActive(false);
                    masks.GetChild(1).gameObject.SetActive(false);
                }
            }
        }
    }

    void ChangeMask(Vector2 move)
    {
        if (move == Vector2.right)
        {
            saved = false;
            masks.GetChild(currentMask).gameObject.SetActive(false);
            currentMask++;
            if (currentMask == masks.childCount)
            {
                currentMask = 2;
            }
            Transform current = masks.GetChild(currentMask);
            current.gameObject.SetActive(true);
            if (current.gameObject.tag == "EditorOnly")
            {
                if (transform.GetChild(currentGFX).gameObject.tag == "Shootable")
                {
                    masks.GetChild(1).gameObject.SetActive(true);
                    masks.GetChild(0).gameObject.SetActive(false);
                }
                else
                {
                    masks.GetChild(0).gameObject.SetActive(true);
                    masks.GetChild(1).gameObject.SetActive(false);
                }
            }
            else
            {
                masks.GetChild(0).gameObject.SetActive(false);
                masks.GetChild(1).gameObject.SetActive(false);
            }
        }
        else
        {
            saved = false;
            masks.GetChild(currentMask).gameObject.SetActive(false);
            currentMask--;
            if (currentMask == -1)
            {
                currentMask = masks.childCount - 1;
            }
            Transform newCurrent = masks.GetChild(currentMask);
            newCurrent.gameObject.SetActive(true);
            if (newCurrent.gameObject.tag == "EditorOnly")
            {
                if (transform.GetChild(currentGFX).gameObject.tag == "Shootable")
                {
                    masks.GetChild(1).gameObject.SetActive(true);
                    masks.GetChild(0).gameObject.SetActive(false);
                }
                else
                {
                    masks.GetChild(0).gameObject.SetActive(true);
                    masks.GetChild(1).gameObject.SetActive(false);
                }
            }
            else
            {
                masks.GetChild(0).gameObject.SetActive(false);
                masks.GetChild(1).gameObject.SetActive(false);
            }
        }
    }

}

