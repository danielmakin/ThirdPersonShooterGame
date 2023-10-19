using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAgentHealth : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;
    Ragdoll ragdoll;
    public float blinkIntenstity;
    float blinkTime;
    AIAgent agent;
    public float blinkDuration;
    public UIHealthBar healthBar;
    SkinnedMeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<AIAgent>();
        currentHealth = maxHealth;
        ragdoll = GetComponent<Ragdoll>();
        meshRenderer = GetComponentInChildren<SkinnedMeshRenderer>();
        //THIS GETS ALL OF THE HITBOXES
        var rigidBodies = GetComponentsInChildren<Rigidbody>();

        foreach (var body in rigidBodies){
            //THIS NOW ADDS THE SCRIPT TO EACH ONE
            HitBox box = body.gameObject.AddComponent<HitBox>();
            box.Health = this;
        }
    }

    // Update is called once per frame
    public void TakeDamage(float Damage, Vector3 direction)
    {
        currentHealth -= Damage;
        if (currentHealth <= 0f)
        {
            Die(direction);
        }
        else
        {
            //THIS THEN CHANGES THE HEALTH VALUE
            healthBar.SetHealth(currentHealth);
        }

        blinkTime = blinkDuration;
    }

    private void Die(Vector3 direction)
    {
        AIDeathState deathState = agent.stateMachine.GetState(AIStateID.Death) as AIDeathState;
        deathState.direction = direction;
        agent.stateMachine.ChangeState(AIStateID.Death);

    }

    private void Update()
    {
        blinkTime -= Time.deltaTime;
        float lerp = Mathf.Clamp01(blinkTime / blinkDuration);
        float intensity = (lerp * blinkIntenstity) + 1;
        meshRenderer.material.color = Color.white * intensity;
    }
}
