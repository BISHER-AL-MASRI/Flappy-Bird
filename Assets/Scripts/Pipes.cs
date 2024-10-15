using UnityEngine;

public class Pipes : MonoBehaviour
{
    public Transform top;
    public Transform bottom;
    public float speed = 3f;
    public float gap = 3f;
    public float acceleration = 0.1f; // Add this variable for acceleration

    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
        top.position += Vector3.up * gap / 2;
        bottom.position += Vector3.down * gap / 2;
    }

    private void Update()
    {
        // Increment the speed by the acceleration value
        speed += acceleration * Time.deltaTime;

        // Move the pipes to the left
        transform.position += speed * Time.deltaTime * Vector3.left;

        // Destroy the pipes if they move past the left edge of the screen
        if (transform.position.x < leftEdge) {
            Destroy(gameObject);
        }
    }
}