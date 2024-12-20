using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMove : IBehavior
{

    [SerializeField] private Transform entity;
    [SerializeField] private Vector3 direction;
    [SerializeField] private float speed;
    public void Enter(IController controller)
    {
        entity = controller.Entity;
        direction = controller.Direction;
        speed = controller.Speed;
    }

    public void Execute(IController controller)
    {
        entity.Translate(direction * speed * Time.deltaTime);
    }

    public void Exit(IController controller)
    {
        
    }
}
