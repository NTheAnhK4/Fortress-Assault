public interface IBehavior
{
    void Enter(ActorController controller);
    void Execute(ActorController controller);
    void Exite(ActorController controller);
}