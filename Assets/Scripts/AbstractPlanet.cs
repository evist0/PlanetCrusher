using UnityEngine;

namespace PlanetCrusher
{
    public abstract class AbstractPlanet : MonoBehaviour, IPlanetSurface
    {
        public abstract float GetHeight(Vector2 coord);
        public abstract Vector3 GetTangent(Vector3 @from, Vector3 direction);
    }
}