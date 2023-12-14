using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeKillerBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

void OnTriggerEnter(Collider col)
{
    Debug.Log("Trigger!");

    // Vérifier si le collider a un tag "Cube"
    if (col.CompareTag("Cube"))
    {
        GameObject colliderGo = col.gameObject;
        Destroy(colliderGo);
    }
    else
    {
        Debug.Log("Not a cube!");
    }
}


}
