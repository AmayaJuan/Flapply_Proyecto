using UnityEngine;

public class Bird : MonoBehaviour
{
    RorateBird rotateBird;
    bool isDead;
    float upForce = 200f;
    Rigidbody2D rb;
    Animator animator;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        rotateBird = GetComponent<RorateBird>();
    }

	void Update ()
    {
        if (isDead) return;

        if (GameController.instance.game && Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * upForce);
            animator.SetTrigger("Flap");
            SoundSystem.instance.PlayFlap();
        }
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        isDead = true;
        animator.SetTrigger("Die");
        rotateBird.enabled = false;
        GameController.instance.BirdDie();
        rb.velocity = Vector2.zero;
        SoundSystem.instance.PlayHit();
    }
}
