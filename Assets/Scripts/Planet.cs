using UnityEngine;

namespace PlanetCrusher
{
    public class Planet : AbstractPlanet
    {
        [SerializeField] private float height;

        public override float GetHeight(Vector2 coord)
        {
            return height;
        }

        public override Vector3 GetTangent(Vector3 from, Vector3 direction)
        {
            var relative = from - transform.position;

            return -Vector3.Cross(relative, Vector3.Cross(relative, direction)).normalized;
        }
    }
}