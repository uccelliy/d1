using UnityEngine;

namespace Base
{

    public abstract class BaseController : MonoBehaviour
    {

        protected Rigidbody2D rb;
        protected Animator animator;
        protected BaseStateMchine stateMachine;

        public virtual void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
            animator = GetComponent<Animator>();
        }

        public void changeState(BaseState newState)
        {
            if (stateMachine == null)
            {
                stateMachine = new BaseStateMchine(this);
            }
            stateMachine.ChangeState(newState);
        }
        // 可提供给状态使用的通用方法
        public void Move(Vector2 velocity)
        {
            rb.velocity = velocity;
        }

        public void PlayAnim(string name)
        {
            animator.Play(name);
        }

        public bool IsGrounded()
        {
            // 可后续用 Raycast 检测地面
            return true;
        }

        public abstract void Start();
        public abstract void Update();
        public abstract void FixedUpdate();
        public abstract void LateUpdate();
        public abstract void OnDestroy();

        // Add any common functionality or properties that all controllers should have
    }
}