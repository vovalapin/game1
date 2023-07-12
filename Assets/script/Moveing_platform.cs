using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveing_platform : MonoBehaviour
{
    float dirX;
    float speed = 10f;
    bool moveingRight = true;
    // Update is called once per frame
    void Update()
    {
      if ( transform.position.x > 30f)
        {
            moveingRight = false;
        }
         else if (transform.position.x < -60f)
        {
            moveingRight = true;
        }
      if (moveingRight)
        {
            transform.position = new Vector2 (transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }
}
