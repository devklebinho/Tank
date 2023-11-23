using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform origin;

    [SerializeField] PlayerInput _playerInput;
    [SerializeField] InputActionReference _actionReference;

    [SerializeField] InputAction shoot;
    void Awake()
    {
        shoot = _playerInput.actions.FindAction(_actionReference.action.id);
    }

    void Update()
    {
        //Debug.Log(shoot.triggered);
        if (shoot.triggered)
        {
            Instantiate(bullet, origin.position, transform.rotation);
        }
    }

    void OnActionPeformed(InputAction.CallbackContext action)
    {
        Debug.Log(action.performed);
    }

}
