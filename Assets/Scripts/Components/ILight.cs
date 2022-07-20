using UnityEngine;

namespace Components
{
    public interface ILight { 
        Light Light { get; }
    }

    public interface ISimpleLight : ILight {  }

    public interface IGradientLight : ILight {
        Gradient Gradient { get; }
    }
}
