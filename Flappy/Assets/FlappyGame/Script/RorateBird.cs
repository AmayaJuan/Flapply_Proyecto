using UnityEngine;

public class RorateBird : MonoBehaviour
{
    float MaxDownVelocity = -5f;
    float MaxDownAngle = -90f;
    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
	
	void Update ()
    {
        if (rb != null)
        {
            float currentVelocity = Mathf.Clamp(rb.velocity.y, MaxDownVelocity, 0);
            float angle = (currentVelocity / MaxDownVelocity) * MaxDownAngle;
            Quaternion rotation = Quaternion.Euler(0, 0, angle);
            transform.rotation = rotation;
        }
	}
}
