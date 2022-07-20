using Components;

public abstract class LightBehaviour<T> : BaseBehaviour, ILightBehaviour where T : ILight
{
    protected T light;

    public LightBehaviour (T light) {
        this.light = light;
    }
}

public interface ILightBehaviour : IBehaviour { }
