using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemies : MonoBehaviour
{
    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;
    public Transform spawn4;
    public Transform spawn5;
    public Transform spawn6;
    public Transform spawn7;
    public Transform spawn8;
    public Transform spawn9;

    public float timeBetweenEnemies;
    public float enemyTimer;
    public float enemyCounter;

    public GameObject enemy;

    public Transform spawnerLocation;
    // Start is called before the first frame update
    void Start()
    {
        spawnerLocation = this.gameObject.transform;
        timeBetweenEnemies = 1f;
        enemyCounter = 0;
        enemyTimer = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameRunningScript.gameRunning)
        {
            enemyTimer -= Time.deltaTime;
            if (enemyTimer <= 0)
            {
                enemyTimer = timeBetweenEnemies;
                spawnEnemy();
            }
        }
    }

    void spawnEnemy()
    {
        enemyCounter++;
        int x = Random.Range(0, 8);

        switch (x)
        {
            case 0:
                Instantiate(enemy, spawn1.position, spawnerLocation.rotation);
                break;
            case 1:
                Instantiate(enemy, spawn2.position, spawnerLocation.rotation);
                break;
            case 2:
                Instantiate(enemy, spawn3.position, spawnerLocation.rotation);
                break;
            case 3:
                Instantiate(enemy, spawn4.position, spawnerLocation.rotation);
                break;
            case 4:
                Instantiate(enemy, spawn5.position, spawnerLocation.rotation);
                break;
            case 5:
                Instantiate(enemy, spawn6.position, spawnerLocation.rotation);
                break;
            case 6:
                Instantiate(enemy, spawn7.position, spawnerLocation.rotation);
                break;
            case 7:
                Instantiate(enemy, spawn8.position, spawnerLocation.rotation);
                break;
            case 8:
                Instantiate(enemy, spawn9.position, spawnerLocation.rotation);
                break;
            default:
                
                break;
        }
        /*//if(x == 0)
        // {
        Vector3 bluh = new Vector3(spawnerLocation.position.x+10, spawnerLocation.position.y, spawnerLocation.position.z + Random.Range(-10.0f, 10.0f));
            Instantiate(enemy, bluh, spawnerLocation.rotation);
       // }*/
    }
}
