using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class ParticleCollisionDetector : MonoBehaviour
{
    private ParticleSystem ps;

    public string[] targetTags;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();

        var collisionModule = ps.collision;
        collisionModule.enabled = true;

        var mainModule = ps.main;
        mainModule.simulationSpace = ParticleSystemSimulationSpace.World;
    }

    void OnParticleCollision(GameObject other)
    {
        foreach (string targetTag in targetTags)
        {
            if (other.CompareTag(targetTag))
            {
                // Debug.Log("Particle collided with object of tag: " + targetTag);

                ReduceScale(other);
            }
        }
    }

    // void ReduceScale(GameObject obj)
    // {
    //     // Réduisez la taille de l'objet en modifiant sa scale.
    //     obj.transform.localScale *= 0.99f; // Vous pouvez ajuster ce facteur selon vos besoins.
    // }

    void ReduceScale(GameObject obj)
    {
        // Vérifiez le tag de l'objet
        string objTag = obj.tag;
        // Debug.Log("objTag: " + objTag);

        // Facteur d'ajustement de la scale
        float scaleAdjustment = 1.005f; // Vous pouvez ajuster ce facteur selon vos besoins.

        // Modifiez la scale en fonction du tag de l'objet
        if (objTag.Equals("scaleX"))
        {
            // Debug.Log("collided scaleX");
            obj.transform.localScale = new Vector3(obj.transform.localScale.x * scaleAdjustment, obj.transform.localScale.y, obj.transform.localScale.z);
        }
        else if (objTag.Equals("scaleY"))
        {
            // Debug.Log("collided scaleY");
            obj.transform.localScale = new Vector3(obj.transform.localScale.x, obj.transform.localScale.y * scaleAdjustment, obj.transform.localScale.z);
        }
        else if (objTag.Equals("allScale"))
        {
            // Debug.Log("collided allScale");
            obj.transform.localScale *= scaleAdjustment;
        }
        else if (objTag.Equals("allScaleDown"))
        {
            // Debug.Log("collided allScaleDown");
            obj.transform.localScale /= scaleAdjustment;
        }
    }

}
