using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed = 10f;
    public float boundary = 8f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x + horizontal, -boundary, boundary);
        transform.position = position;
    }
}
