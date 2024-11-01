using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    private int enemyCount = 10; // 한 번에 스폰될 적의 수

    public GameObject enemyPrefab; //적 프리팹
    public float spawnInterval; //생성 간격

    private void Start()
    {
        StartCoroutine(SpawnCoroutine());
    }

    private IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
            {
                Spawn(enemyCount);
            }

            yield return new WaitForSeconds(1f);

        }
    }


    List<Enemy> enemies = new List<Enemy>();
    private void Spawn(int count)
    {
        for (int i = 0; i < count; i++)
        {
            float x = Random.Range(3f, 10f); 
            float y = Random.Range(0.5f, 0.6f); 


            Vector2 spawnPos = new Vector2(x, y);
            GameObject enemyObject = Instantiate(enemyPrefab, spawnPos, Quaternion.identity);


            Enemy enemy = enemyObject.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemies.Add(enemy); 
                enemy.hp += 0.1f;
                enemy.damage += 1f;
            }
        }
    }
}
