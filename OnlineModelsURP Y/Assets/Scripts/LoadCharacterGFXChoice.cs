using UnityEngine;
using System.IO;

public class LoadCharacterGFXChoice : MonoBehaviour
{
    public Transform masks;
    void Start()
    {
        if (File.Exists(Application.persistentDataPath + "/player.gfx"))
        {
            PlayerData data = SavePlayer.LoadPlayer();
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(data.GFX).gameObject.SetActive(true);
            masks.GetChild(0).gameObject.SetActive(false);
            masks.GetChild(data.mask).gameObject.SetActive(true);

            if (masks.GetChild(data.mask).gameObject.tag == "EditorOnly")
            {
                if (transform.GetChild(data.GFX).gameObject.tag == "Shootable")
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
