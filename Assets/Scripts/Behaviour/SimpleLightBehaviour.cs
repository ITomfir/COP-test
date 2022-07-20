using Components;
using Commands;
using UnityEngine;

public class SimpleLightBehaviour : LightBehaviour<ISimpleLight>
{
    public SimpleLightBehaviour (ISimpleLight light) : base(light) {

    }

    public override void Command (ICommand command) {
        if (command is SetColorCommand setColor) SetColorLight(setColor.color);
    }

    public override void Update () {
        
    }

    private void SetColorLight (Color color) {
        light.Light.color = color;
    }
}
