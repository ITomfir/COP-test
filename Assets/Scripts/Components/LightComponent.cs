using Components;
using UnityEngine;

public class LightComponent : MonoBehaviour, ISimpleLight
{
    [SerializeField] private Light _light;
    [SerializeField] private Color _color;

    public Light Light => _light;
    public Color Color => _color;
}
