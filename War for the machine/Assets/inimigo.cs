using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {

        //check, if gameobject has tag Inimigo
        if (other.gameObject.tag == "projetil")
        {
            //decrementar o número de vidas
            Destroy(gameObject);


        }
    }

}
