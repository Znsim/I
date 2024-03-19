using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class black : MonoBehaviour
{
    public GameObject bulletPrefab; // 발사할 총알 프리팹
    public Transform firePoint; // 총알이 발사될 위치
    public float bulletSpeed = 10f; // 총알의 속도

    void Update()
    {
        // 스페이스바를 누르면 총알을 발사
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    void Fire()
    {
        // 총알 프리팹을 인스턴스화하여 총알 오브젝트 생성
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // 총알에 속도 적용
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
