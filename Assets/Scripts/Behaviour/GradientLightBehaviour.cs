using Components;
using Commands;
using UnityEngine;

public class GradientLightBehaviour : LightBehaviour<IGradientLight>
{
    public GradientLightBehaviour (IGradientLight light) : base(light) {

    }

    public override void Command (ICommand command) {
        
    }

    public override void Update () {
        var color = light.Gradient.Evaluate(Mathf.Repeat(Mathf.PingPong(Time.time, 50), 50) / 50f);
        SetColorLight(color);
    }

    private void SetColorLight (Color color) {
        light.Light.color = color;
    }
}
