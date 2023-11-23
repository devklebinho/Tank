using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankMovement : MonoBehaviour
{
    [SerializeField] PlayerInput _playerInput;
    [SerializeField] InputActionReference _actionReference;

    private InputAction move;
    
    [SerializeField] float speed;
    Rigidbody2D body;

    private void Awake()
    {
        move = _playerInput.actions.FindAction(_actionReference.action.id);
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        Vector2 movement = move.ReadValue<Vector2>();
        body.velocity = movement * speed;
    }

    private void OnEnable()
    {
        move.performed += OnActionPerformed;
        move.canceled += OnActionCanceled;
    }

    private void OnDisable()
    {
        move.performed -= OnActionPerformed; 
        move.canceled -= OnActionCanceled;
    }

    private void OnActionPerformed(InputAction.CallbackContext context)
    {        
        Vector2 movement = context.ReadValue<Vector2>();
        Debug.Log($"Input [{movement.x}] [{movement.y}] moving");
    }

    private void OnActionCanceled(InputAction.CallbackContext context)
    {
        Debug.Log("Action canceled");
        Vector2 movement = context.ReadValue<Vector2>();
        Debug.Log($"Input [{movement.x}] [{movement.y}] stop");
    }


}
