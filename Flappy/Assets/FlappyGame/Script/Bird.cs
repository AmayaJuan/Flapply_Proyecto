using UnityEngine;

public class Bird : MonoBehaviour
{
    bool isDead;
    float upForce = 200f;
    Rigidbody2D rb;
    Animator animator;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

	void Update ()
    {
        if (isDead) return;

        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * upForce);
            animator.SetTrigger("Flap");
        }
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        isDead = true;
        animator.SetTrigger("Die");
        GameController.instance.BirdDie();
        rb.velocity = Vector2.zero;
    }
}
