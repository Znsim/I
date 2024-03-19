using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float moveSpeed = 5f; // 이동 속도

    void Update()
    {
        // 키보드 입력을 받아 이동 방향을 설정
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // 이동 방향에 따라 이동 벡터 설정
        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0f);

        // 이동 벡터를 정규화하여 대각선 이동 시 일정한 속도를 유지하도록 함
        moveDirection.Normalize();

        // 오브젝트를 이동시키는 벡터 계산
        Vector3 moveVector = moveDirection * moveSpeed * Time.deltaTime;

        // 이동 벡터를 현재 위치에 더함으로써 오브젝트를 이동시킴
        transform.Translate(moveVector);
    }
}
