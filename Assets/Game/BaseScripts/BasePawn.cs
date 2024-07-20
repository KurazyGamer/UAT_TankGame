using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasePawn : MonoBehaviour
{
    public BaseMover mover;
    public float moveSpeed;
    public float turnSpeed;
    public Shooter shooter;

    public virtual void Start()
    {
        mover = GetComponent<BaseMover>();
        shooter = GetComponent<Shooter>();
    }

    
    public virtual void Update()
    {
        
    }

    public abstract void MoveForward();
    public abstract void MoveBackward();
    public abstract void RotateClockwise();
    public abstract void RotateCounterClockwise();
    public abstract void Shoot();
}
