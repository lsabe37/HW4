using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private CapsuleCollider2D playerCollider;
    [SerializeField] private float jumpForce;

    public delegate void pointEvent();
    public event pointEvent getPoint;

    public delegate void gameOverEvent();
    public event gameOverEvent gameOver;

    public delegate void jumpEvent();
    public event jumpEvent jump;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            jump();
        }
    }
    private void Jump()
    {
        rb.velocity = new Vector2(0, jumpForce);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Pipe"))
        {
            gameOver();
        }

        if (collider.gameObject.CompareTag("Point"))
        {
            getPoint();
        }
    }
}
