using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject enemy;

    // Start is called before the first frame update
    void Start() {
        InvokeRepeating("SpawnEnemy", 1f, 1f);
    }

    // Update is called once per frame
    void Update() {
    }

    void SpawnEnemy() {
        Vector2 spawnPosition = new Vector2(Random.Range(-8f, 8f), transform.position.y);
        Instantiate(enemy, spawnPosition, Quaternion.identity);
    }

}
