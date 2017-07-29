using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    float groundHorizontalLength;
    BoxCollider2D groundCollider;

    void Awake()
    {
        groundCollider = GetComponent<BoxCollider2D>();
    }

    void Start ()
    {
        groundHorizontalLength = groundCollider.size.x;
    }
	
	void Update ()
    {
        if (transform.position.x < -groundHorizontalLength)
            RepositionBackground();
	}

    void RepositionBackground()
    {
        transform.Translate(Vector2.right * groundHorizontalLength * 2);
    }
}
