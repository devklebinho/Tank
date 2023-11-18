using SpriteAnimations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    float moveX;
    float moveY;
    [SerializeField] SpriteAnimator anim;

    void Start()
    {
        anim = GetComponent<SpriteAnimator>();
    }

    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

        if (moveX != 0 || moveY != 0)
        {
            anim.Play("Walk");
        }
        else
        {
            anim.Play("Idle");
        }
    }
}
