using UnityEngine;
using Components;

public class Lantern : Actor
{
    protected override void Init() {
        if (TryGetComponent<ISimpleLight>(out var light)) {
            Add(new SimpleLightBehaviour(light));
            Command(new SetColorCommand(new Color(250, 0, 0, 0)));  
            return;
        }
        
        if (TryGetComponent<IGradientLight>(out var gradientLight)) {
            Add(new GradientLightBehaviour(gradientLight));
            return;
        }
        
        Debug.LogError("No light component " + gameObject.name); 
    }
}
