using UnityEngine;

public class CubeScript : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        // Détruire la particule
        ParticleSystem ps = other.GetComponent<ParticleSystem>();
        if (ps != null)
        {
            ParticleSystem.Particle[] particles = new ParticleSystem.Particle[ps.main.maxParticles];
            int numParticles = ps.GetParticles(particles);

            for (int i = 0; i < numParticles; i++)
            {
                particles[i].remainingLifetime = 0f; // Détruire la particule
            }

            ps.SetParticles(particles, numParticles); // Mettre à jour les particules dans le système
            Debug.Log("Particules détruites par collision avec l'objet B !");
        }
    }
}
