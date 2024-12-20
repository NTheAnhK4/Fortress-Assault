using System;
using UnityEngine;

public abstract class IController : ParentBehavior
{
    [SerializeField] private Transform entity;
    [SerializeField] private Vector3 direction;
    [SerializeField] private float speed;
    private IBehavior currentBehavior;

    public Transform Entity => entity;

    public Vector3 Direction => direction;

    public float Speed
    {
        get => speed;
        set => speed = value;
    }
    
    protected override void LoadComponent()
    {
        currentBehavior = new EMove();
        currentBehavior.Enter(this);
        entity = transform;
        speed = 1f;
        direction = Vector3.right;
    }

    private void ChangBehavior(IBehavior newBehavior)
    {
        currentBehavior?.Exit(this);
        currentBehavior = newBehavior;
        currentBehavior?.Enter(this);
    }

    private void Update()
    {
        currentBehavior.Execute(this);
    }
}