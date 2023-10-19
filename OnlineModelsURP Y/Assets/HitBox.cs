using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : MonoBehaviour
{
    public AIAgentHealth Health;
    // Start is called before the first frame update
    public void OnRaycastHit(Gun Weapon, Vector3 direction)
    {
        Health.TakeDamage(Weapon.damage, direction);
    }
}
