using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] private Collider2D playerCollider;
    [SerializeField] private Rigidbody2D playerRigidbody;
    [SerializeField] private Animator playerAnimator;

    void Start()
    {
        playerCollider = GetComponent<Collider2D>();
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
        if (playerCollider == null)
        {
            Debug.LogError("Player Collider is not assigned or found.");
        }
        if (playerRigidbody == null)
        {
            Debug.LogError("Player Rigidbody is not assigned or found.");
        }
        if (playerAnimator == null)
        {
            Debug.LogError("Player Animator is not assigned or found.");
        }
    }

    void Update()
    {
        
    }
}
