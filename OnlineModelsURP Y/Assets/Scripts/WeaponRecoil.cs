using UnityEngine;
using Cinemachine;

public class WeaponRecoil : MonoBehaviour
{
    [HideInInspector] public CinemachineFreeLook playerCam;
    [HideInInspector] public CinemachineImpulseSource cameraShake;
    [HideInInspector] public Animator rigController;
    public float verticalRecoil;
    public float duration;
    public string weaponName;

    float time;

    private void Awake()
    {
        cameraShake = GetComponent<CinemachineImpulseSource>();

    }

    public void GenerateRecoil()
    {
        time = duration;

        cameraShake.GenerateImpulse(Camera.main.transform.forward);

        rigController.Play("weapon_recoil_" + weaponName, 1, 0.0f);
    }
    private void Update()
    {
        if (time > 0)
        {
            playerCam.m_YAxis.Value -= ((verticalRecoil/1000) * Time.deltaTime) / duration;
            time -= Time.deltaTime;

        }
    }
}
