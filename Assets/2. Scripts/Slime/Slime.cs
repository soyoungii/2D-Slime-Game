using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    [Tooltip("���Ϳ��� �ִ� ���ط�")] 
    public float damage = 1; //���ݷ� -> ������ 1 ����
    [Tooltip("ĳ���� ü��")]
    public float hp = 5; //ü�� -> ������ 5 ����
    [Tooltip("5�ʸ��� ü�� ȸ��")]
    public float hpRecovery = 0; //ü�� ȸ���� -> ������ 0.6 ����
    [Tooltip("ĳ������ �������� ġ��Ÿ ȿ���� ������ Ȯ��")]
    public float critical = 0; //ġ��Ÿ Ȯ�� -> Max��: 100 -> ������ 1%����
    [Tooltip("ġ��Ÿ ������ �⺻��")]
    public float criticalDamage = 0; //ġ��Ÿ ���� -> ������ 1% ����
    [Tooltip("�⺻ ������ ���ݼӵ�")]
    public float attackSpeed = 1; //���ݼӵ� ������ 0.1 ���� -> ������ 0.1 ����
    [Tooltip("�⺻ ������ �߰��� �߻����� ���ϴ� ����")] 
    public float doubleShot = 0; //���� -> ���� Ƚ���� ����? -> ������ 1%����?1����?
 
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




