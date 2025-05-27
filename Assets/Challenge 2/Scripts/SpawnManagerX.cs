using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;

    void Start()
    {
        StartCoroutine(SpawnBallRoutine());
    }

    IEnumerator SpawnBallRoutine()
    {
        yield return new WaitForSeconds(startDelay);

        while (true)
        {
            SpawnRandomBall();
            float randomInterval = Random.Range(3f, 5f); // intervalo aleatório entre 3 e 5 segundos
            yield return new WaitForSeconds(randomInterval);
        }
    }

    void SpawnRandomBall()
    {
        int index = Random.Range(0, ballPrefabs.Length);

        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[index].transform.rotation);
    }


}
