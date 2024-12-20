

public interface IBehavior
{
    void Enter(IController controller);
    void Execute(IController controller);
    void Exit(IController controller);
}
