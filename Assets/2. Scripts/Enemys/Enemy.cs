using Lean.Pool;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Tooltip("ĳ���Ϳ��� �ִ� ���ط�")]
    public float damage = 1f; //���ݷ�
    [Tooltip("���� ü��")]
    public float hp = 1f; //ü��
    public float moveSpeed; //�̵��ӵ�

    private Transform target; //���� ���(������)
    private Rigidbody2D rb;

    private bool isActive = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void Start()
    {
        //GameManager.Instance.enemies.Add(this);
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        EnemyMove();
    }

    public void EnemyMove()
    {
        if (isActive)
        {
            Vector3 direction = target.position - transform.position;
            direction.Normalize();

            transform.position += direction * moveSpeed * Time.deltaTime;
        }

    }

    public void StopEnemy()
    {
        moveSpeed = 0f;
        //Vector3.Distance(transform.position, target.position);
    }

    public void TakeDamage(float damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Die();
        }
    }

    public void SlimeDie()
    {
        damage = 1;
        hp = 1;
    }

    public void Die()
    {
        GameManager.Instance.slime.gold += 10;
        Destroy(gameObject);
        //LeanPool.Despawn(gameObject); -> leanpool ���� �̰ɷ� �ٲٱ�
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SlimeColl"))
        {
            StopEnemy();
        }
    }
}

//public GameObject enemyProjectile; //���� ����ü ������
//private void OnCollisionStay2D(Collision2D collision)
//{
//    // �÷��̾�� ������ �ִ� ���� �����ϱ�

//    // ������ �������� �� ���� + ������ ���� = ���� �������� ��� �� ����
//    // ���� �������� ��� �� ������ < ���� �ð� : �������� ���� �ʵ���.
//    if (preDamageTime + damageInterval > Time.time)
//    {
//        return;
//    }

//    if (collision.collider.CompareTag("Player"))
//    {
//        collision.collider.GetComponent<Player>().TakeDamage(damage);
//        var particle = Instantiate(impactParticle, collision.GetContact(0).point, Quaternion.identity);
//        particle.Play();
//        Destroy(particle.gameObject, 2f);
//        preDamageTime = Time.time;
//    }
//}

