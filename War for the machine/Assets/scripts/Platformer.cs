using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Platformer : MonoBehaviour
{
    //public float speed;
    // Start is called before the first frame update
   // Rigidbody2D rb;

    public float moveSpeed;
    private bool isMoving;
    private Vector2 pantufinha;

    public int pontos = 0;
    public int vidas = 3;
    private numerovidas lifeSystem;
    private numeroPontos pointsSystem;
    private gameoverScript gameOver;
    



    void Start()
    {
       // rb = GetComponent<Rigidbody2D>();
       
        lifeSystem = FindObjectOfType<numerovidas>();
        pointsSystem = FindObjectOfType<numeroPontos>();
        gameOver = FindObjectOfType<gameoverScript>();
     
    }

    // Update is called once per frame
    private void Update()
    {
        if (!isMoving)
        {
           pantufinha.x = Input.GetAxisRaw("Horizontal");
           pantufinha.y = Input.GetAxisRaw("Vertical");

            if (pantufinha != Vector2.zero)
            {
                var targetPos = transform.position;
                targetPos.x += targetPos.x + 0.01f * pantufinha.x; 
                targetPos.y += targetPos.y + 0.01f * pantufinha.y;
                transform.position = targetPos;
                StartCoroutine(Move(targetPos));
               
            }

        }
   
   IEnumerator Move(Vector3 targetPos)
    {
        isMoving = true;
           
            while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
            {
                
                transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            yield return null;
        }
        
        isMoving = false;

    }
        /* void OnTriggerEnter2D(Collider2D other)
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
             }*/
    }
}