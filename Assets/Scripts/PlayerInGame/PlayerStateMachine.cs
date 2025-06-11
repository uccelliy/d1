using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Base;

public class PlayerStateMachine : BaseStateMchine
{
    public PlayerStateMachine(BaseController owner) : base(owner)
    {
        // Initialize any state-specific properties or references here
    }
    public override void Enter()
    {
        Debug.Log("Player State Machine Entered");
    }

    public override void Exit()
    {
        Debug.Log("Player State Machine Exited");
    }

    public override void Update()
    {
        Debug.Log("Player State Machine Updating");
    }

    public override void FixedUpdate()
    {
        Debug.Log("Player State Machine Fixed Updating");
    }


    // Start is called before the first frame update
}
