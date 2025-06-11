using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Base;
public class RunState : BaseState
{
    // Start is called before the first frame update
    public RunState(BaseController owner) : base(owner)
    {
    }
    public override void Enter()
    {
        Debug.Log("Run State Entered");
        owner.PlayAnim("Run");
    }
    public override void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        if (Mathf.Abs(moveInput) < 0.01f)
        {
            owner.changeState(new IdleState(owner));
        }
        else
        {
            owner.Move(new Vector2(moveInput, 0));
        }
    }
    
}
