﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D _rg;
    float speed = 5f;
    private Animator _playerAnimator;
    
    void Start()
    {

        _rg = GetComponent<Rigidbody2D>();
        _playerAnimator = GetComponent<Animator>();



        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        
    }

    private void Movement()
    {
        float Hmove = Input.GetAxisRaw("Horizontal");
        float Vmove = Input.GetAxisRaw("Vertical");
        _playerAnimator.SetFloat("moveX", Hmove);
        _playerAnimator.SetFloat("moveY", Vmove);

        _rg.velocity = new Vector2(Hmove*speed,Vmove*speed);

        if(Hmove == 1|| Hmove ==-1||Vmove==1||Vmove == -1)
        {
            _playerAnimator.SetFloat("lastMoveX",Hmove);
            _playerAnimator.SetFloat("lastMoveY", Vmove);
        }

      
    }
}
