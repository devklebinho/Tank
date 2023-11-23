using SpriteAnimations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimations : MonoBehaviour
{

    [SerializeField] SpriteAnimator anim;

    [SerializeField] PlayerInput _playerInput;
    [SerializeField] InputActionReference _actionReference;

    private InputAction move;

    void Awake()
    {
        anim = GetComponent<SpriteAnimator>();
        move = _playerInput.actions.FindAction(_actionReference.action.id);
    }

    void Update()
    {
        Vector2 movement = move.ReadValue<Vector2>();
        
        if(movement == Vector2.zero)
        {
            anim.Play("Idle");
        }
        else
        {
            anim.Play("Walk");
        }

        if(movement.y < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if (movement.y > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if(movement.x < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        else if (movement.x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 270);
        }
    }
}