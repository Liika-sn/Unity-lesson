using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = 0.4f;
    public int damage = 10;
    public int direction;
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag =="enemy")
        {
            GameObject temp = collision.gameObject;
            temp.GetComponent<Enemy>().health -= 20;
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject, 3f);
    }

    void Update()
    {
        transform.position += Vector3.right * direction * speed;
    }
}
