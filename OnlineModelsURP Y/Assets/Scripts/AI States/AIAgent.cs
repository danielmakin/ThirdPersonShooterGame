using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class AIAgent : MonoBehaviour
{
    public AIStateMachine stateMachine;
    public AIStateID initialState;
    public NavMeshAgent navMeshAgent;
    public AIAgentConfig config;
    public Transform playerLoc;
    public Ragdoll ragdoll;
    public SkinnedMeshRenderer mesh;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        //THIS CREATES A STATE MACHINE
        ragdoll = GetComponent<Ragdoll>();
        mesh = GetComponentInChildren<SkinnedMeshRenderer>();
        stateMachine = new AIStateMachine(this);
        stateMachine.ChangeState(initialState);
        stateMachine.RegisterState(new AIStateChasePlayer());
        stateMachine.RegisterState(new AIDeathState());
        stateMachine.RegisterState(new AIIdleState());
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        stateMachine.Update();
    }
}
