using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankMovement : MonoBehaviour
{
    [SerializeField] PlayerInput _playerInput;

    private InputAction move;

    [SerializeField] InputActionReference _actionReference;


    [SerializeField] float speed;
    [SerializeField] Rigidbody2D body;

    private void Awake()
    {
        move = _playerInput.actions.FindAction(_actionReference.action.id);
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
