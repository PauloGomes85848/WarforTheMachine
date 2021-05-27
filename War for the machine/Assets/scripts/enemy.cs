using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    private GameObject player;
    private RaycastHit2D sighttest;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void FixedUpdate()
    {
        //precompute raysettings
        Vector3 start = transform.position;
        Vector3 direction = player.transform.position - transform.position;

        float distance = 5.5f;

        //draw ray in editor
        //Debug.DrawRay(start, direction * distance, Color.red, 2f, false);

        sighttest = Physics2D.Raycast(start, direction, distance);

        if (sighttest != null && sighttest.collider != null)
        {
            //if(sighttest.collider.tag == "player") Debug.Log(sighttest.collider.tag);
        }
    }
}
