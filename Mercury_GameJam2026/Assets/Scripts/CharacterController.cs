using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour
{
    public float speed = 5f;
    public bool canMoveVertical = true;

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
        movement.y = canMoveVertical ? Input.GetAxis("Vertical") : 0;

        // SAĞA SOLA DÖNME
        if (movement.x > 0)
        {
            sr.flipX = false; // sağa bak
        }
        else if (movement.x < 0)
        {
            sr.flipX = true; // sola bak
        }

    }

    void FixedUpdate()
    {
        rb.velocity = movement * speed;

        float h = Input.GetAxis("Horizontal");
        float v = canMoveVertical ? Input.GetAxis("Vertical") : 0;

        animator.SetFloat("Horizontal", h);
        animator.SetFloat("Vertical", v);

        float speedValue = movement.magnitude;
        animator.SetFloat("Speed", speedValue);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Portal"))
        {
            SceneManager.LoadScene("EndsScene");
            Debug.Log("Portala girdin");
        }
    }
}