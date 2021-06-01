using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
public class enemy : MonoBehaviour
{
 
    public float speed;  //10
    //public float stoppingDistance;  //7
    public float shootingdistance;
    private float waitTime;
    public float startWaitTime;

    private float timeBtwShots;
    public float startTimeBtwShots;

    public GameObject projectile;
    private Transform player;

    public Transform moveSpot;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public Animator animator;
    

    //public Transform goal;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").transform;
        timeBtwShots = startTimeBtwShots;

        waitTime = startWaitTime;
       // moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        // target = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
      //  NavMeshAgent agent = GetComponent<NavMeshAgent>();
        //agent.destination = goal.position;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpot.position, speed * Time.deltaTime);

       /* if (Vector2.Distance(tranform.position, player.position) < shootingdistance)
        {

        }*/

        animator.SetFloat("Speed", Mathf.Abs(speed * Time.deltaTime));

       
         

        if (Vector2.Distance(transform.position, player.position) <= shootingdistance)
        {
            
            
            if (timeBtwShots <= 0)
            {
                Instantiate(projectile, transform.position, Quaternion.identity);
                timeBtwShots = startTimeBtwShots;
                animator.SetBool("IsShooting", true);
                
            }
            else
            {
                timeBtwShots -= Time.deltaTime;
            }
        }else if (Vector2.Distance(transform.position, moveSpot.position) < 0.2f)
            {
                if (waitTime <= 0)
                {
                    moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
                    waitTime = startWaitTime;
                }
                else
                {
                    waitTime -= Time.deltaTime;
                }
            }

    }
        /*
       if (Vector2.Distance(transform.position, target.position) > 3)
       {
           transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
       }
       */
    

}
