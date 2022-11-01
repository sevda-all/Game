using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BidenMove : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform[] waypoints;
    public GameObject trump;
    int cur = 0;
    public float speed = 0.08f;
    public float moveSpeed = 1;
    public float StartTime;
    public float End = 0.25f;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (transform.position != waypoints[cur].position) 
        {
            Vector2 startPos = transform.position;
            Vector2 endPos = waypoints[cur].position;

            if(startPos.ToString().Equals(endPos.ToString()))
            {   
                cur = (cur + 1) % waypoints.Length;
            }
            else
            {
                Vector2 p = Vector2.MoveTowards(transform.position, waypoints[cur].position, speed);
                rb.MovePosition(p);
            }
        }
        StartTime += 0.1f * Time.deltaTime;

        if(StartTime >= End)
        {
          if(Vector2.Distance(transform.position, trump.transform.position) < 4)
            transform.position = Vector2.MoveTowards(transform.position, trump.transform.position, moveSpeed * Time.deltaTime);
        } 
        
    }

   
    
}
