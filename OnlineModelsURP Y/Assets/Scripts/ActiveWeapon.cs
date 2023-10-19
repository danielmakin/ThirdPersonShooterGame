using UnityEngine;
using UnityEngine.Animations.Rigging;
using Cinemachine;
using TMPro;

public class ActiveWeapon : MonoBehaviour
{
    private InputActions controls;
    private Gun[] weapon;
    public Transform crosshair;
    public Transform weaponParent;
    public ParticleSystem impactEffect;
    public Animator animator;
    public PlayerMovement movement;
    public CinemachineFreeLook playerCamera;

    public TextMeshProUGUI[] boxes;

    public const int maxIndex = 3;

    int currentIndex;
    int pastIndex;

    public Rig handIK;
    
    public Animator rigController;



    private void Awake()
    {
        controls = new InputActions();
        controls.Main.Shoot.performed += ctx => Shoot(true);
        controls.Main.Shoot.canceled += ctx => Shoot(false);

        controls.Main.LSwitch.performed += ctx => ChangeWeapon(false);
        controls.Main.RSwitch.performed += ctx => ChangeWeapon(true);
        
    }
    void Start()
    {
        boxes[0].fontStyle = FontStyles.Bold;
        weapon = new Gun[maxIndex + 1];
        Gun existingWeapon = GetComponentInChildren<Gun>();
        if (existingWeapon)
        {
            Equip(existingWeapon);
        }
        else
        {
            handIK.weight = 0f;
        }
    }

    private void ChangeWeapon(bool yes)
    {
        pastIndex = currentIndex;
        currentIndex = GetNextIndex(yes);
        if (weapon[currentIndex])
        {
            weapon[currentIndex].gameObject.SetActive(true);
            handIK.weight = 1.0f;
            rigController.Play("equip_" + weapon[currentIndex].animationName);
            if (weapon[pastIndex])
            {
                weapon[pastIndex].gameObject.SetActive(false);
            }
        }
        else if (weapon[pastIndex])
        {
            LeanTween.value(1.0f, 0f, 0.1f).setOnUpdate((float val) =>
            {
                handIK.weight = val;
            });

            if (weapon[pastIndex])
            {
                weapon[pastIndex].gameObject.SetActive(false);
            }

        }
        boxes[pastIndex].fontStyle = FontStyles.Normal;
        boxes[currentIndex].fontStyle = FontStyles.Bold;
    }

    int GetNextIndex(bool yes)
    {
        int nextIndex = 0;

        if (yes)
        {
            nextIndex = currentIndex + 1;
            if (nextIndex > maxIndex)
            {
                nextIndex = 0;
            }
        }
        else
        {
            nextIndex = currentIndex - 1;
            if (nextIndex == -1)
            {
                nextIndex = maxIndex;
            }
        }
        return nextIndex;
    }

    private void OnEnable()
    {
        controls.Main.Enable();
        controls.PauseScreen.Disable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }


    void Shoot(bool yes)
    {
        
        if (weapon[currentIndex])
        {
            if (yes)
            {
                weapon[currentIndex].StartFiring();
            }
            else
            {
                weapon[currentIndex].StopFiring();
            }
            weapon[currentIndex].UpdateBullets(Time.deltaTime);
            if (weapon[currentIndex].shoot)
            {
                weapon[currentIndex].UpdateFire(Time.deltaTime);
            }
        }
    }

    public void Equip(Gun newWeapon)
    {
        if (weapon[currentIndex])
        {
            Destroy(weapon[currentIndex].gameObject);
        }
        if (currentIndex != 0)
        {
            weapon[currentIndex] = newWeapon;
            weapon[currentIndex].gameObject.SetActive(true);
            ResetNewGun(currentIndex);
            rigController.Play("equip_" + weapon[currentIndex].animationName);
            boxes[currentIndex].text = weapon[currentIndex].displayedName;
        }
        else
        {
            Destroy(newWeapon.gameObject);
        }
    }

    private void ResetNewGun(int count)
    {
        weapon[count].raycastDest = crosshair;
        weapon[count].recoil.playerCam = playerCamera;
        weapon[count].recoil.rigController = rigController;
        weapon[count].transform.parent = weaponParent;
        weapon[count].transform.localPosition = Vector3.zero;
        weapon[count].transform.localRotation = Quaternion.identity;
        weapon[count].hitEffect = impactEffect;
        handIK.weight = 1.0f;
    }

    
}
