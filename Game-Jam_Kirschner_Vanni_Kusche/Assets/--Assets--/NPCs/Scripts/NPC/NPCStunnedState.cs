using System;
using UnityEngine;


[Serializable]
public class NPCStunnedState : BaseState
{
    public float MinWaitTime;
    public float MaxWaitTime;

    public GameObject indicator;

    private float leaveTime;

    public override void OnEnterState(BaseStateMachine controller)
    {
        Debug.Log("NPCStunnedState:OnEnterState");

        leaveTime = Time.time + UnityEngine.Random.Range(MinWaitTime, MaxWaitTime);
        NPCStateMachine npcStateMachine = controller as NPCStateMachine;

        //npcStateMachine.SetDestination(Vector3.zero);
        indicator.SetActive(true);
    }

    public override void OnUpdateState(BaseStateMachine controller)
    {
        Debug.Log("NPCStunnedState:OnUpdateState");
        NPCStateMachine npcStateMachine = controller as NPCStateMachine;

        // Transitions
        // Time is up > Swicth
        if(Time.time > leaveTime) 
        {
            npcStateMachine.SwitchToState(npcStateMachine.IdleState);
        }

    }

    public override void OnExitState(BaseStateMachine controller)
    {
        Debug.Log("NPCStunnedState:OnExitState");
        indicator.SetActive(false);
    }
}
