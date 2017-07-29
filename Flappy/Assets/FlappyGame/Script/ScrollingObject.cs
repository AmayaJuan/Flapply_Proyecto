using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start ()
    {
        rb.velocity = new Vector2(GameController.instance.scrollSpeed, 0);
    }
	
	void Update ()
    {
        if (GameController.instance.gameOver)
            rb.velocity = Vector2.zero;
	}
}
