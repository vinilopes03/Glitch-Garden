﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawnner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Attacker attackerPrefab;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {

            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }

    }

    private void SpawnAttacker()
    {
       Attacker newAttacker = Instantiate(attackerPrefab, transform.position, transform.rotation) as Attacker;
        newAttacker.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
}
