using UnityEngine;

public class GestionParticle : MonoBehaviour
{
    // Référence vers le Particle System
    public ParticleSystem myParticleSystem;


    // Variable pour activer ou désactiver le Particle System
    public bool activerParticleSystem = false;

    // Propriété privée, mais visible dans l'éditeur Unity
    [SerializeField]
    // Propriété privée
    private bool isParticle = false;

    // Accesseur get pour isParticle
    public bool IsParticle
    {
        get { return isParticle; }
    }

    void Update()
    {
        // Vérifier la valeur de la variable et activer/désactiver le Particle System en conséquence
        if (activerParticleSystem)
        {
            ActiverParticleSystem();
        }
        else
        {
            DesactiverParticleSystem();
        }
    }

    void ActiverParticleSystem()
    {
        // Activer le Particle System
        if (!myParticleSystem.isPlaying)
        {
            myParticleSystem.Play();
        }
    }

    void DesactiverParticleSystem()
    {
        // Désactiver le Particle System
        if (myParticleSystem.isPlaying)
        {
            myParticleSystem.Stop();
        }
    }
}
