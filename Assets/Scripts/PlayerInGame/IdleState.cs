using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Base;
public class IdleState : BaseState
{
    public IdleState(BaseController owner) : base(owner)
    {
    }

    public override void Enter()
    {
        Debug.Log("Idle State Entered");
        owner.PlayAnim("Idle");
    }

    public override void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        if (Mathf.Abs(moveInput) > 0.01f)
        {
            owner.changeState(new RunState(owner as BaseController));
        }
    }
    // Start is called before the first frame update
}
