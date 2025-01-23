using UnityEngine;

public class MovingScript : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Move the object to the left
        transform.position += -transform.right * speed * Time.deltaTime;
    }
}