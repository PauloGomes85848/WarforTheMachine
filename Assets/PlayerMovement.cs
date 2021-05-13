using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float horizontal;
    public float vertical;
    Vector2 position;

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

    }

    void FixedUpdate() 
    {
        
        Vector2 position = transform.position;
        position.x = position.x + 0.5f * horizontal * Time.deltaTime;
        position.y = position.y + 0.5f * vertical * Time.deltaTime;
        transform.position = position;
    }
}
