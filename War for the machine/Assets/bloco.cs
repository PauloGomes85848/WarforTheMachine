using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloco : MonoBehaviour
{
    public GameObject blocoPila;
    public GameObject peça;

    void Start()
    {
        blocoPila = GameObject.Find("Bloco");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "bloco")
        {
            Destroy(blocoPila);
            Instantiate(peça, new Vector3(3, -2, -2), Quaternion.identity);
        }
    }
}
