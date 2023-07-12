using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    public Rigidbody2D rb;
   public float agroDistance = 2f;
    public Transform playr;
 


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
        private void Update()
    {
     float distToPlayer = Vector2.Distance(transform.position, playr.position);
        if (distToPlayer < agroDistance ) {

            StartHanting();
        }
        else
        {
            StopHunting();
        }
    }

    void StartHanting()
    {
        if ( playr.position.x < transform.position.x ) 
        { 
        rb.velocity = new Vector2(-speed, 0);
            transform.localScale = new Vector2(8, 8);
        }
        else if (playr.position.x > transform.position.x)
        {
            rb.velocity = new Vector2(speed, 0);
            transform.localScale = new Vector2(-8, 8);
        }
        
    }
      void StopHunting()
        {
            rb.velocity = new Vector2(0, 0);
        }

    public void EnemyHurt()
    {
        Destroy(this.gameObject);
    }
}
