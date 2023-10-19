using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int GFX;
    public int mask;

    public PlayerData(int GFXnew, int masknew)
    {
        GFX = GFXnew;
        mask = masknew;
    }

}
