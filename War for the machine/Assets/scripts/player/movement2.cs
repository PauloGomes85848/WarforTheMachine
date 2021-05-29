
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2 : MonoBehaviour
{
    public float moveSpeed;
    public float horizontal;
    public float vertical;
    public int nPecas = 0;
    Rigidbody2D rb;
    public int vidas = 3;
    private numeroPecas pecasSystem;
    Vector2 position;
    public GameObject nextlevel;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pecasSystem = FindObjectOfType<numeroPecas>();
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {


    }

    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x = position.x + moveSpeed * horizontal * Time.deltaTime;
        position.y = position.y + moveSpeed * vertical * Time.deltaTime;
        transform.position = position;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //check, if gameobject has tag Moeda
       
        if (other.gameObject.CompareTag("pecaa"))
        {
          
            //incrementar o número de pontos
            nPecas = nPecas + 1;
            Debug.Log("npecas= " + nPecas);
            pecasSystem.addPeca();
            //Debug.Log(pecasSystem);
            //delete Moeda gameobject from the scene
            Destroy(other.gameObject);
            Instantiate(nextlevel, new Vector3(9.07f, -1.6f, 0), Quaternion.identity);
                 
        }
    }
    public void OnLevelWasLoaded(int level)
    {
            FindStartPos();

    }

    void FindStartPos()
    {
        transform.position = GameObject.FindWithTag("StartPos").transform.position;
    }
}