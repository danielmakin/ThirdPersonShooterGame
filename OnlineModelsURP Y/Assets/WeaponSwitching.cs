using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    InputActions actions;
    public Gun[] guns;
    public Gun[] currentGuns;
    int maxIndex;
    public ActiveWeapon active;
    int currentIndex;
    private void OnEnable()
    {
        actions.PopUp.Disable();
        actions.PauseScreen.Disable();
        actions.Main.Enable();
    }

    private void OnDisable()
    {
        actions.Main.Disable();
    }

    private void Awake()
    {
        actions = new InputActions();
        actions.Main.LSwitch.performed += ctx => ChangeGun(false);
        actions.Main.RSwitch.performed += ctx => ChangeGun(true);
    }

    public void AddNewGun(Gun gunfab)
    {
        guns[maxIndex] = gunfab;
        maxIndex++;
    }

    private void ChangeGun(bool yes)
    {
        if (yes)
        {
            if (currentIndex == maxIndex)
            {
                currentIndex = 0;
            }
            else
            {
                currentIndex++;
            }
            active.Equip(currentGuns[currentIndex]);
        }
        else
        {
            if (currentIndex == 0)
            {
                currentIndex = maxIndex;
            }
            else
            {
                currentIndex--;
            }
            active.Equip(currentGuns[currentIndex]);
        }
    }
}
