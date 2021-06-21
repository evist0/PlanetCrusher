using UnityEngine;

namespace PlanetCrusher
{
    public interface IPlanetSurface
    {
        public float GetHeight(Vector2 coord);

        public Vector3 GetTangent(Vector3 from, Vector3 direction);
    }
}