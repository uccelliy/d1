using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Base;
public class PlayerController2D : BaseController
{
    [Header("移动参数")]

    [Header("爬墙参数")]
 
    
    [SerializeField] private Collider2D playerCollider;
    [SerializeField] private Animator playerAnimator;
    [SerializeField] private Rigidbody2D playerRigidbody;

    
    private bool isGrounded;

    // 输入缓存
    private float horizontalInput;
    private float verticalInput;
    private bool jumpPressed;

    

    void Move()
    {
        
    }

    void Jump()
    {
        
    }

    void Climb()
    {
        
    }

    public override void Start()
    {
        Debug.Log("PlayerController2D Start");
    }

    public override void Update()
    {
        Debug.Log("PlayerController2D Update");
    }

    public override void FixedUpdate()
    {
        Debug.Log("PlayerController2D FixedUpdate");
    }

    public override void LateUpdate()
    {
        Debug.Log("PlayerController2D LateUpdate");
    }

    public override void OnDestroy()
    {
        Debug.Log("PlayerController2D OnDestroy");
    }
}