using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed = 1f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy1"))
        {
            Debug.Log("Bateu no bichão");
            GameManager.Instance.AddScore(20);
            Destroy(gameObject);
        }
    }
}