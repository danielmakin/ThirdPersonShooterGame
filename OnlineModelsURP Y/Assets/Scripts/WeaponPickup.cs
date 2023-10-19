using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    public Gun gunFab;

    private void OnTriggerEnter(Collider other)
    {
        ActiveWeapon weapon = other.gameObject.GetComponent<ActiveWeapon>();
        if (weapon)
        {
            Gun gun = Instantiate(gunFab);
            weapon.Equip(gun);
        }
    }
}
