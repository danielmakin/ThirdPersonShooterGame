using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDeathState : AIState
{
    public Vector3 direction;

    public void Enter(AIAgent agent)
    {
        agent.ragdoll.ActivateRagdoll(true);
        direction.y = 1;
        agent.ragdoll.ApplyForce(direction * agent.config.dieForce);
        //THE HEALTH BAR SHOULD NOT BE SEEN
        agent.slider.gameObject.SetActive(false);
    }

    public void Exit(AIAgent agent)
    {
    }

    public AIStateID GetID()
    {
        return AIStateID.Death;
    }

    public void Update(AIAgent agent)
    {
    }
}
