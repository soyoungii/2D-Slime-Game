using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Enemy", menuName = "Scriptable Object/Enemy Data", order = 1)]
public class EnemySO : ScriptableObject
{
    public string enemyName;
    public float enemySpeed;
    public float hp;
    public float damage;
    //[NonSerialized] public Sprite sprite; //적 이미지

}
