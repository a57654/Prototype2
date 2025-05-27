using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float cooldown = 1.5f;         // Tempo mínimo entre lançamentos
    private float nextSpawnTime = 0f;      // Próximo momento em que o cachorro pode ser lançado

    void Update()
    {
        // Pressionar espaço E já passou o tempo de espera?
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextSpawnTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            nextSpawnTime = Time.time + cooldown; // Atualiza o tempo do próximo lançamento permitido
        }
    }
}
