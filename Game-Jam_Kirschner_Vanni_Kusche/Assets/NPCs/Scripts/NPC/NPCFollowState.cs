using System;
using UnityEngine;

[Serializable]
public class NPCFollowState : BaseState
{

    public float FollowDistance;

    private Vector3 _followPosition;


    public override void OnEnterState(BaseStateMachine controller)
    {
        Debug.Log("NPCFollowState:OnEnterState");
        NPCStateMachine npcStateMachine = controller as NPCStateMachine;

        //npcStateMachine.SetDestination(npcStateMachine.PlayerPosition);
        //npcStateMachine.SetDestination(Vector3.zero);

    }

    public override void OnUpdateState(BaseStateMachine controller)
    {
        Debug.Log("NPCFollowState:OnUpdateState");
        NPCStateMachine npcStateMachine = controller as NPCStateMachine;

        //npcStateMachine.SetDestination(npcStateMachine.PlayerPosition);
        //npcStateMachine.SetAgentSpeedMultiplier(2.5f);

        npcStateMachine.SetDestination(npcStateMachine.PlayerPosition);

        // Can see or hear player > Switch to flee
        if (!npcStateMachine.CanSeePlayer && !npcStateMachine.CanHearPlayer)
        {
            npcStateMachine.SwitchToState(npcStateMachine.IdleState);
        }
       
    }

    public override void OnExitState(BaseStateMachine controller)
    {
        Debug.Log("NPCFollowState:OnExitState");
        NPCStateMachine npcStateMachine = controller as NPCStateMachine;

        npcStateMachine.SetAgentSpeedMultiplier(1f);
    }

}

