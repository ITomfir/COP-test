using Commands;
using UnityEngine;

public struct SetColorCommand : ICommand { 
    public Color color;

    public SetColorCommand (Color color) {
        this.color = color;
    }
}
