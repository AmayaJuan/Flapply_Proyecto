using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    public int nivel;
    float scrollSpeed = -1.5f;
    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start ()
    {
        rb.velocity = new Vector2(scrollSpeed, 0);
    }
	
	void Update ()
    {
        if (nivel == 1)
        {
            if (GameController.instance.gameOver)
                rb.velocity = Vector2.zero;
        }
	}
}
