using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightMove : IMove
{
    
    public void Move(MoveState moveState)
    {
        moveState.Actor.Translate(moveState.Speed * moveState.Direction * Time.deltaTime);
    }
}
