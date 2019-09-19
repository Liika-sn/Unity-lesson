using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    GameObject CurrentEnemy;
    public GameObject enemyPref;
    void Start()
    {
        CurrentEnemy = Instantiate(enemyPref, transform.position, Quaternion.identity);
    }

    
    void Update()
    {
        if(CurrentEnemy == null)
        {
            CurrentEnemy = Instantiate(enemyPref, transform.position, Quaternion.identity);
        }
    }
}
