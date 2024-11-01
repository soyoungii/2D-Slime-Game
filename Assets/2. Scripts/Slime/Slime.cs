using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    [Tooltip("몬스터에게 주는 피해량")] 
    public float damage = 1; //공격력 -> 레벨당 1 증가
    [Tooltip("캐릭터 체력")]
    public float hp = 5; //체력 -> 레벨당 5 증가
    [Tooltip("5초마다 체력 회복")]
    public float hpRecovery = 0; //체력 회복량 -> 레벨당 0.6 증가
    [Tooltip("캐릭터의 데미지에 치명타 효과를 적용할 확률")]
    public float critical = 0; //치명타 확률 -> Max값: 100 -> 레벨당 1%증가
    [Tooltip("치명타 배율의 기본값")]
    public float criticalDamage = 0; //치명타 피해 -> 레벨당 1% 증가
    [Tooltip("기본 공격의 공격속도")]
    public float attackSpeed = 1; //공격속도 레벨당 0.1 증가 -> 레벨당 0.1 증가
    [Tooltip("기본 공격을 추가로 발사할지 정하는 스탯")] 
    public float doubleShot = 0; //더블샷 -> 관통 횟수도 설정? -> 레벨당 1%증가?1증가?
 
    public float gold = 0;
    public GameObject projectile;



    public void TakeDamage(float damage)
    {
        hp -= damage;
        if(hp <= 0)
        {
            
        }
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (TryGetComponent<Enemy>(out Enemy enemy))
    //    {
    //        if (collision.CompareTag("Player"))
    //        {
    //            //enemy.EnemyMove(false);

    //        }
    //    }
    //}

}




