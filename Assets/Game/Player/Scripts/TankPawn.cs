using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPawn : BasePawn
{
    public override void MoveForward()
    { 
        mover.Move(transform.forward, moveSpeed);
    }

    public override void MoveBackward()
    {
        mover.Move(transform.forward, -moveSpeed);
    }

    public override void RotateClockwise()
    {
        mover.Rotate(turnSpeed);
    }

    public override void RotateCounterClockwise()
    {
        mover.Rotate(-turnSpeed);
    }

    public override void Shoot()
    {
        shooter.Shoot();
    }

    public override void Start()
    {
        base.Start();
    }

    
    public override void Update()
    {
        base.Update();
    }

    
}
