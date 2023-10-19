using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIStateMachine
{
    public AIState[] states;
    public AIAgent agent;
    public AIStateID currentState;

    public AIStateMachine(AIAgent agent)
    {
        //THIS INITIALISES THE AGENT AND CREATES AN ARRAY
        this.agent = agent;
        int numStates = System.Enum.GetNames(typeof(AIStateID)).Length;
        states = new AIState[numStates];
    }

    public void RegisterState(AIState state)
    {
        //THIS VOID REGESTERS A STATE
        int index = (int)state.GetID();
        states[index] = state;
    }

    public void Update()
    {
        GetState(currentState)?.Update(agent);
    }

    public AIState GetState(AIStateID stateID)
    {
        //THIS GETS THE STATE AT AN INDEX
        int index = (int)stateID;
        return states[index];
    }

    public void ChangeState(AIStateID newState)
    {
        //THIS CHANGES THE STATE
        GetState(currentState)?.Exit(agent);
        currentState = newState;
        GetState(currentState)?.Enter(agent);
    }
}
