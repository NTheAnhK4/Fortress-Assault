
using UnityEngine;
[RequireComponent(typeof(SupportActorCtrl))]
public class ActorController : ParentBehavior
{
    [SerializeField] private SupportActorCtrl support;
    [SerializeField] private Transform actor;
    [SerializeField] private Vector3 direction;
    [SerializeField] private ActorParam param;

    private IBehavior curBehavior;

    public ActorParam Param => param;

    public Transform Actor => actor;

    public Vector3 Direction => direction;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        if (support == null) support = transform.GetComponent<SupportActorCtrl>();
        actor = transform;
        direction = Vector3.right;
        param = support.Data.data[support.ActorId];
        curBehavior = new MoveState();
        curBehavior.Enter(this);
    }

    private void Update()
    {
        curBehavior.Execute(this);
    }
}
