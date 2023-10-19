using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIStateChasePlayer : AIState
{
    float timer;

    public void Enter(AIAgent agent)
    {

    }

    public void Exit(AIAgent agent)
    {
        
    }

    public AIStateID GetID()
    {
        return AIStateID.ChasePlayer;
    }

    public void Update(AIAgent agent)
    {
        if (!agent.enabled)
        {
            return;
        }
        timer -= Time.deltaTime;
        if (!agent.navMeshAgent.hasPath)
        {
            agent.navMeshAgent.destination = agent.playerLoc.position;
        }
        if (timer < 0.0f)
        {
            float sqdistance = (agent.playerLoc.position - agent.navMeshAgent.destination).sqrMagnitude;
            if (sqdistance > (agent.config.maxDistance * agent.config.maxDistance))
            {
                if (agent.navMeshAgent.pathStatus != NavMeshPathStatus.PathPartial)
                {
                    agent.navMeshAgent.destination = agent.playerLoc.position;
                }
            }
            timer = agent.config.maxTime;
        }
    }
}
