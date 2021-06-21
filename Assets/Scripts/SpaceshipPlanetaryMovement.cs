using UnityEngine;

namespace PlanetCrusher
{
    public class SpaceshipPlanetaryMovement : MonoBehaviour
    {
        [SerializeField] private AbstractPlanet planet;
        [SerializeField] private float speed;

        private Vector3 ConstrainToPlanet(Vector3 coord)
        {
            var planetPosition = planet.transform.position;
            var relative = coord - planetPosition;
            
            return planetPosition + relative.normalized * planet.GetHeight(Vector2.zero);
        }

        private void Update()
        {
            var t = transform;
            var p = t.position;

            var planetPosition = planet.transform.position;
            
            var relative = p - planetPosition;
            var desiredPosition = ConstrainToPlanet(p);

            var tangent = planet.GetTangent(p, t.forward + t.rotation * new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime, 0));

            t.position =
                ConstrainToPlanet(desiredPosition + tangent * (speed * Input.GetAxis("Vertical") * Time.deltaTime));
            t.rotation = Quaternion.LookRotation(tangent, relative.normalized);
        }
    }
}