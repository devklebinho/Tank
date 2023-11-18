using SpriteAnimations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RbMovement : MonoBehaviour
{
    Rigidbody2D rb;
    float moveX;
    float moveY;
    [SerializeField] float speed;
    [SerializeField] SpriteAnimator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<SpriteAnimator>();
        //anim.Play("Idle");
    }

    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveX * speed, moveY * speed);

        if (moveX != 0 && moveY != 0)
        {
            rb.velocity = Vector2.zero;
        }
        else
        {
            //Flip Vertical
            if (moveY > 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else if (moveY < 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 180);
            }

            //Flip Horizontal
            if (moveX > 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 270);
            }
            else if (moveX < 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 90);
            }
        }

    }
}