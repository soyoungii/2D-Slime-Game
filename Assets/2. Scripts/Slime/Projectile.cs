using Lean.Pool;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float damage; //���ݷ�(���ط�)
    public float attakSpeed; //���ݼӵ�
    public float critical; //ġ��Ÿ Ȯ��
    public float criticalDamage; //ġ��Ÿ ����
    public float doubleShot;
    public float rotateSpeed; //�⺻���� ����ü�� ȸ�� �ӵ�
    public float launchSpeed = 10f; // �߻� �ӵ�

    private Rigidbody rb;

    private CircleCollider2D followEnemy;

    private void Awake()
    {
        //followEnemy = GetComponent<CircleCollider2D>();
        //followEnemy.enabled = false;
        rb = GetComponent<Rigidbody>();
    }

    public GameObject projectilePrefab; // ����ü ������
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

