using UnityEngine;

public class BallController : MonoBehaviour
{
    public float initialSpeed = 600f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(initialSpeed, initialSpeed));
    }
}
