using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BidenFollowing : MonoBehaviour
{
    public GameObject trump;
    public float moveSpeed ; 

    void Start()
    { 
    }

  
    void Update()
    {
        if(Vector2.Distance(transform.position, trump.transform.position) < 3)
        transform.position = Vector2.MoveTowards(transform.position, trump.transform.position, moveSpeed * Time.deltaTime);
       
    }
     
    

    
}
