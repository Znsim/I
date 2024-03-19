using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float moveSpeed = 5f; // �̵� �ӵ�

    void Update()
    {
        // Ű���� �Է��� �޾� �̵� ������ ����
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // �̵� ���⿡ ���� �̵� ���� ����
        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0f);

        // �̵� ���͸� ����ȭ�Ͽ� �밢�� �̵� �� ������ �ӵ��� �����ϵ��� ��
        moveDirection.Normalize();

        // ������Ʈ�� �̵���Ű�� ���� ���
        Vector3 moveVector = moveDirection * moveSpeed * Time.deltaTime;

        // �̵� ���͸� ���� ��ġ�� �������ν� ������Ʈ�� �̵���Ŵ
        transform.Translate(moveVector);
    }
}
