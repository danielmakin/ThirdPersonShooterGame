using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdoll : MonoBehaviour
{
    Rigidbody[] rigidBodies;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rigidBodies = GetComponentsInChildren<Rigidbody>();
        animator = GetComponent<Animator>();
        ActivateRagdoll(false);
    }

    public void ActivateRagdoll(bool Activate)
    {
        foreach (var rigidBody in rigidBodies)
        {
            rigidBody.isKinematic = !Activate;
        }

        animator.enabled = !Activate;

        if (Activate)
        {
            //THIS THEN DISABLES THE AI
            GetComponent<AIMovement>().enabled = false;
        }
    }

    public void ApplyForce(Vector3 force)
    {
        //THIS ADDS A DEATH EFFECT
        var rigidBody = animator.GetBoneTransform(HumanBodyBones.Hips).GetComponent<Rigidbody>();
        rigidBody.AddForce(force, ForceMode.VelocityChange);
    }
}
