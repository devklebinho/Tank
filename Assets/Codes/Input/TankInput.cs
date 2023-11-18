using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankInput : MonoBehaviour
{ 
    public void Shoot(InputAction.CallbackContext action)
    {
        if (action.performed)
        {
            Debug.Log("Piu!");
        }
    }

    public void OnMovement(InputAction.CallbackContext action)
    {
        Vector2 movement = action.ReadValue<Vector2>();
        
        if (action.performed)
        {
            Debug.Log($"Input [{movement.x}] [{movement.y}] moving");
        }
        
        if (action.canceled)
        {
            Debug.Log($"Input [{movement.x}] [{movement.y}] stop");
        }
    }
}
