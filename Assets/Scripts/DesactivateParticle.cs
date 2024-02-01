using UnityEngine;

public class DesactivateParticle : MonoBehaviour
{
    // Référence vers le Particle System
    public ParticleSystem myParticleSystem;

    // Variable pour activer ou désactiver le Particle System
    public bool activerParticleSystem = false;

    void Start()
    {
        myParticleSystem.Stop();
    }



}
