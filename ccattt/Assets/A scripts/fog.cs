using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fog : MonoBehaviour
{
    public Rigidbody2D fog_;
    //public float SIDE = 0.5;
    int det = 0;

    private void Awake()
    {
        fog_ = GetComponent<Rigidbody2D>();
    }

  //  public float speedF = 10f;

   // private Vector2 _movement;

    public void Start()
    {

    }

    public void Update()
    {
        if(det == 0)
        {
            fog_.velocity = new Vector2(0.5f, 0f);
        }
        else if (det == 1)
        {
            fog_.velocity = new Vector2(-0.5f, 0f);
        }
       

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "colli")
        {
            det = 1;
        }

        if (collision.gameObject.tag == "colli_back")
        {
            det = 0;
        }
    }

    
        
    

}
