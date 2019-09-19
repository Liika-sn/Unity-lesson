using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    private Rigidbody2D _rigidbody;

    void Start()
    {
        
    }

    void Update()
    {
        if(health<=0)
        {
            Destroy(gameObject, 1f);
        }
    }
}
