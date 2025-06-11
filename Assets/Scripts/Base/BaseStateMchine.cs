
using UnityEngine;
using Base;
namespace Base
{

    public class BaseStateMchine
    {
        public BaseState CurrentState { get; private set; }

        public void Initialize(BaseState initialState)
        {
            CurrentState = initialState;
            CurrentState?.Enter();
        }

        public void ChangeState(BaseState newState)
        {
            CurrentState?.Exit();
            CurrentState = newState;
            CurrentState?.Enter();
        }
        protected BaseController owner;

        public BaseStateMchine(BaseController owner)
        {
            this.owner = owner;
        }
        // Start is called before the first frame update
        public virtual void Enter()
        {
            Debug.Log("Base State Machine Entered");
        }

        public virtual void FixedUpdate()
        {
            Debug.Log("Base State Machine Fixed Updating");
        }
        public virtual void Update()
        {
            Debug.Log("Base State Machine Updating");
        }
        public virtual void Exit()
        {
            Debug.Log("Base State Machine Exited");
        }

    }
}