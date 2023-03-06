using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMoveto : MonoBehaviour
{
    public bool Move;
    private float speed = 8f;
    private float step;
    public static bool firstHit;

    private void Start()
    {
        Move = false;
    }
    private void FixedUpdate()
    {
        
        if (Move == true) {
            step = speed * Time.deltaTime;
            
            gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position,Wall.NextPosition,step);
            if (Vector2.Distance(gameObject.transform.position, Wall.NextPosition) < 0.0001f)
            {
                
                Destroy(this.gameObject);
                

            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "death")
        {
            BallSpawner.BallCount --;
            Destroy(other.gameObject); 
        }
        if(other.gameObject.tag == "cube")
        {
            BallSpawner.BallCount ++;
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "Door")
        {
            GameManager.instance.Winner();
        }
        if(other.gameObject.tag == "score")
        {
            //Increment Score
            Destroy(other.gameObject);
            GameManager.instance.InrementScore();
             
        }
        
    }
    
    private void OnDestroy()
    {
        if (firstHit == false)
        {
            firstHit = true;
        }
        //gameObject.transform.parent.GetComponent<BallSpawner>().list.Remove(this.gameObject);
        Wall.count++;
    }

}
