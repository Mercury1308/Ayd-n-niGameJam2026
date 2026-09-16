using UnityEngine;

public class CharacterController2 : MonoBehaviour
{
    public float speed = 5f;
    public Animator animator;
    private Rigidbody2D rb;
    private Vector2 movement;
    private SpriteRenderer sr;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");

        // SAĞA SOLA DÖNME
        if (movement.x > 0)
        {
            sr.flipX = false; // sağa bak
        }
        /*
        else if (movement.x < 0)
        {
            sr.flipX = true; // sola bak
        }
        */
    }

    void FixedUpdate()
    {
        //rb.velocity = movement * speed;

        float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");

        animator.SetFloat("Horizontal", h);
        //animator.SetFloat("Vertical", v);

        float speedValue = movement.magnitude;
        animator.SetFloat("Speed", speedValue);
    }
}