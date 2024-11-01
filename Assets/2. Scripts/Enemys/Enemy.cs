using Lean.Pool;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Tooltip("캐릭터에게 주는 피해량")]
    public float damage = 1f; //공격력
    [Tooltip("몬스터 체력")]
    public float hp = 1f; //체력
    public float moveSpeed; //이동속도

    private Transform target; //추적 대상(슬라임)
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
        //LeanPool.Despawn(gameObject); -> leanpool 사용시 이걸로 바꾸기
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SlimeColl"))
        {
            StopEnemy();
        }
    }
}

//public GameObject enemyProjectile; //적의 투사체 프리팹
//private void OnCollisionStay2D(Collision2D collision)
//{
//    // 플레이어에게 데미지 주는 간격 조정하기

//    // 이전에 데미지를 준 시점 + 데미지 간격 = 다음 데미지를 줘야 할 시점
//    // 다음 데미지를 줘야 할 시점이 < 현재 시간 : 데미지를 주지 않도록.
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

