using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class enemy : MonoBehaviour
{
    public float speed;  //10
    public float stoppingDistance;  //7

    private Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();

    }

    void Update()
    {

        if (Vector2.Distance(transform.position, target.position) > 3)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        }

    }

}
