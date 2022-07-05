using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marcus_controller : MonoBehaviour
{
   //bool for activating and deactivating Marcus controller
    public bool control_status = true;

    //rigidbodies
    public Rigidbody2D marcusRB;


    //movement
    public float mSpeed = 10f;
    private Vector2 _movement;

    private void Start()
    {
    
    }

    private void Update()
    {
        if(control_status == true)
        {
            _movement.x = Input.GetAxisRaw("Horizontal");
            _movement.y = Input.GetAxisRaw("Vertical");
        }
    }

    private void FixedUpdate()
    {
        marcusRB.MovePosition(marcusRB.position + _movement * mSpeed);
    }

}
