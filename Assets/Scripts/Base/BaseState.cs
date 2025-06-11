using UnityEngine;

namespace Base
{
    public abstract class BaseState
    {
        protected BaseController owner;

        public BaseState(BaseController owner)
        {
            this.owner = owner;
        }

        // Called when the state is entered
        public virtual void Enter() { }

        // Called every frame
        public virtual void Update() { }

        // Called every fixed frame-rate frame
        public virtual void FixedUpdate() { }

        // Called after all Update calls
        public virtual void LateUpdate() { }

        // Called when the state is exited
        public virtual void Exit() { }
    }
}