using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class black : MonoBehaviour
{
    public GameObject bulletPrefab; // �߻��� �Ѿ� ������
    public Transform firePoint; // �Ѿ��� �߻�� ��ġ
    public float bulletSpeed = 10f; // �Ѿ��� �ӵ�

    void Update()
    {
        // �����̽��ٸ� ������ �Ѿ��� �߻�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    void Fire()
    {
        // �Ѿ� �������� �ν��Ͻ�ȭ�Ͽ� �Ѿ� ������Ʈ ����
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // �Ѿ˿� �ӵ� ����
        Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();
        if (bulletRb != null)
        {
            bulletRb.velocity = firePoint.up * bulletSpeed;
        }
        else
        {
            Debug.LogError("Bullet prefab must have a Rigidbody component.");
        }
    }
}
