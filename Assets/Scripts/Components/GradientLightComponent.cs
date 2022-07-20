using Components;
using UnityEngine;

public class GradientLightComponent : MonoBehaviour, IGradientLight
{
    [SerializeField] private Light _light;
    [SerializeField] private Gradient _gradient;

    public Light Light => _light;
    public Gradient Gradient => _gradient;
}
