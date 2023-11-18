using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayableCharacter : MonoBehaviour
{
    public float topHealthRate;
    public float moveSpeed;
    public float baseDamage;
    private Rigidbody2D _rb;
    private Animator _animator;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }
    void Update()
    {
        
    }

    protected virtual void Move() {
        
        _rb.MovePosition(_rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        _animator.SetFloat("HorizontalInput", movement.x);
        _animator.SetFloat("VerticalInput", movement.y);
        _animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    protected Vector2 movement; 
    protected abstract void UseSuperability();
}
