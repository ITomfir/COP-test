using Commands;
using System.Collections.Generic;
using UnityEngine;

public abstract class Actor : MonoBehaviour, IActor
{
    private List<IBehaviour> behaviours = new List<IBehaviour>();

    private void Start() {
        Init();
    }

    protected abstract void Init();

    protected virtual void Update() {
        foreach (var behaviour in behaviours)
            behaviour.Update();
    }

    public void Add (IBehaviour behaviour) {
        behaviours.Add(behaviour);
        behaviour.Actor = this;
    }
    
    public void Remove (IBehaviour behaviour) {
        behaviours.Remove(behaviour);
    }

    public void Command (ICommand command) {
        foreach (var behaviour in behaviours) {
            behaviour.Command(command);
        }
    }
}

public interface IActor : IBehaviourStorageOperations {
    void Command(ICommand command);
}
