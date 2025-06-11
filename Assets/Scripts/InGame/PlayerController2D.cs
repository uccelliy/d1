using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
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

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
        playerCollider = GetComponent<Collider2D>();
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
   
    }

    void Move()
    {
        
    }

    void Jump()
    {
        
    }

    void Climb()
    {
        
    }
 
}