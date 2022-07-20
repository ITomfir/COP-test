using Commands;

public abstract class BaseBehaviour : IBehaviour
{
    public IActor Actor { get; set; }

    public abstract void Command (ICommand command);
    public abstract void Update ();
}

public interface IBehaviour {
    IActor Actor { get; set; }

    void Command (ICommand command);
    void Update ();
}
