using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class MoveState : IBehavior
{
    private Vector3 direction;
    private float speed;
    private Transform actor;
    private IMove moveAction;
    public Vector3 Direction => direction;

    public float Speed => speed;

    public Transform Actor => actor;

    private void MoveFactor(ActorController controller)
    {
        switch (controller.Param.MoveData.moveId)
        {
            case MoveId.StraightMove:
                moveAction = new StraightMove();
                break;
        }
    }
    public void Enter(ActorController controller)
    {
        direction = controller.Direction;
        speed = controller.Param.MoveData.moveSpeed;
        actor = controller.Actor;
        MoveFactor(controller);
    }

    public void Execute(ActorController controller)
    {
        moveAction?.Move(this);
    }

    public void Exite(ActorController controller)
    {
        
    }
}
