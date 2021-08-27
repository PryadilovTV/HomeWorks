using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab : MonoBehaviour
{
    private Animator _animator;
    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        if (vertical > 0) MoveForwards();
        else if (vertical < 0) MoveBackwards();
        else Idle();
        
    }
    
    private void MoveForwards()
    {
        _animator.SetBool("MoveForwards", true);
        _animator.SetBool("MoveBackwards", false);
        _animator.SetBool("Idle", false);
        _animator.SetBool("Attack", false);

    }
    private void MoveBackwards()
    {
        _animator.SetBool("MoveForwards", false);
        _animator.SetBool("MoveBackwards", true);
        _animator.SetBool("Idle", false);
        _animator.SetBool("Attack", false);

    }
    private void Idle()
    {
        _animator.SetBool("MoveForwards", false);
        _animator.SetBool("MoveBackwards", false);
        _animator.SetBool("Idle", true);
        _animator.SetBool("Attack", false);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Tree")
        {
            _animator.SetBool("Attack", true);
        }
    }
}
