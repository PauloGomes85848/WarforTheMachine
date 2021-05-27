using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Platformer : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float jumpForce;
    private Animator anim;
    public int pontos = 0;
    public int vidas = 3;
    private numerovidas lifeSystem;
    private numeroPontos pointsSystem;
    private gameoverScript gameOver;
    public GameObject projectile;
    private AudioSource maudioSrc;
   

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        lifeSystem = FindObjectOfType<numerovidas>();
        pointsSystem = FindObjectOfType<numeroPontos>();
        gameOver = FindObjectOfType<gameoverScript>();
        maudioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        
        if (Input.GetButtonDown("Fire2"))
        {
            maudioSrc.Play();
            Rigidbody2D clone;
            clone = Instantiate(projectile.GetComponent<Rigidbody2D>(), transform.position, transform.rotation);
            clone.velocity = transform.TransformDirection(Vector3.right * 10);
            
        }
        }
void FixedUpdate()
    {
        // how fast the player is moving and responds accordingly
        anim.SetFloat("speed", Mathf.Abs(rb.velocity.x));
        // how fast the player is moving and responds accordingly
        anim.SetFloat("jump", Mathf.Abs(rb.velocity.y));
    }
    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * speed;
        rb.velocity = new Vector2(moveBy, rb.velocity.y);
    }
    void Jump() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        //check, if gameobject has tag Moeda
        if (other.tag == "Moeda") {
//incrementar o número de pontos
         pontos = pontos + 1;
        pointsSystem.AddPoint();
        //delete Moeda gameobject from the scene
        Destroy(other.gameObject);
    }
}
    void OnCollisionEnter2D(Collision2D other)
    {
       
        //check, if gameobject has tag Inimigo
        if (other.gameObject.tag == "Inimigo")
        {
            //decrementar o número de vidas
            vidas = vidas - 1;
            lifeSystem.TakeLife();
            Debug.Log("vidas: " + vidas);
            if (vidas == 0)
            {
                Destroy(gameObject);
                gameOver.sayGameOver();
                SceneManager.LoadScene("MenuPrincipal");
            }
        }
    }
}