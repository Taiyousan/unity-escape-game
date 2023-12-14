using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawnerBehaviour : MonoBehaviour
{
    public GameObject cube;
    public float interval = 1f;
    public float conePower = 5.0f;
    public int numDirections = 10;  // Nombre de directions différentes dans lesquelles les cubes peuvent être projetés
    private float _currentTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Chronométrer le temps passé entre le dernier cube créé et maintenant
        _currentTime += Time.deltaTime;

        // Si ce temps dépasse notre intervalle
        if (_currentTime > interval)
        {
            // Utiliser la position du centre du haut du cylindre comme point d'origine
            Vector3 spawnPoint = transform.position + transform.up * GetComponent<MeshRenderer>().bounds.extents.y;

            // Obtenir la normale de la face supérieure du cylindre
            Vector3 faceNormal = transform.up;

            // Calculer une direction aléatoire dans un cône plus restreint autour de la normale
            for (int i = 0; i < numDirections; i++)
            {
                float angle = i * (360f / numDirections);  // Calculer l'angle entre chaque direction
                Vector3 coneDirection = Quaternion.AngleAxis(angle, faceNormal) * faceNormal;

                GameObject newCube = Instantiate(cube, spawnPoint, Quaternion.identity);
                Rigidbody newCubeRb = newCube.GetComponent<Rigidbody>();

                // Appliquer une force dans la direction du cône avec une puissance accrue
                newCubeRb.AddForce(coneDirection * 5, ForceMode.Impulse);
            }

            // Réinitialiser le chronomètre
            _currentTime = 0f;
        }
    }
}
