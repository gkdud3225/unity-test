using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float speed = 8f;

    void Start()
    {
        
    }

    void Update()
    {
        // 위쪽 방향키 입력시, z방향 힘주기
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRigidbody.AddForce(0f, 0f, speed);
        }

        // 아래쪽 방향키 입력시, -z방향 힘주기
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRigidbody.AddForce(0f, 0f, -speed);
        }

        // 오르쪽 방향키 입력시, x방향 힘주기
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }

        // 왼쪽 방향키 입력시, -x방향 힘주기
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }
    }
}
