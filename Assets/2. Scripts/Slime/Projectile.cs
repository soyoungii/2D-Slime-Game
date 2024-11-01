using Lean.Pool;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float damage; //공격력(피해량)
    public float attakSpeed; //공격속도
    public float critical; //치명타 확률
    public float criticalDamage; //치명타 피해
    public float doubleShot;
    public float rotateSpeed; //기본공격 투사체의 회전 속도
    public float launchSpeed = 10f; // 발사 속도

    private Rigidbody rb;

    private CircleCollider2D followEnemy;

    private void Awake()
    {
        //followEnemy = GetComponent<CircleCollider2D>();
        //followEnemy.enabled = false;
        rb = GetComponent<Rigidbody>();
    }

    public GameObject projectilePrefab; // 투사체 프리팹
    private void Start()
    {
    }


    private void Update()
    {
        transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }



}

