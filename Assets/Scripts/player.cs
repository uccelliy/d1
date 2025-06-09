using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // 引用角色控制器组件
    public CharacterController controller;
    // 地面检测点
    public Transform groundCheck;
    // 地面层的掩码
    public LayerMask groundMask;

    float groundDistance = 0.4f; // 地面检测距离
    bool isGrounded; // 是否在地面上
    Vector3 velocity; // 角色的速度
    public float jumpHeight = 1.0f; // 跳跃高度
    public float gravity = -9.81f; // 重力值
    public float speed = 5.0f; // 移动速度
    //使用wasd控制移动 空格控制跳跃

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        {
            Debug.Log("Cursor LockState: " + Cursor.lockState);
        }
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;  // 让角色“粘”在地面上，不至于浮空
        }

    // 移动代码...
    velocity.y += gravity * Time.deltaTime;
    controller.Move(velocity * Time.deltaTime);

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 5);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * 5);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 5);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 5);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up * Time.deltaTime * 5);
        }

        // 使用鼠标控制转向
        float mouseX = Input.GetAxis("Mouse X");
        //float mouseY = Input.GetAxis("Mouse Y");
        transform.Rotate(Vector3.up * mouseX * 2); // Rotate around the Y axis
        //transform.Rotate(Vector3.left * mouseY * 5); // Rotate around the X axis
    }
}
