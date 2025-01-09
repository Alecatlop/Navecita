using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Aro : MonoBehaviour
{
    ManagerAros lista;
    BoxCollider colider;

    // Start is called before the first frame update
    void Start()
    {
        lista = GetComponentInParent<ManagerAros>();
        colider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
           lista.Cambiocolor();
           colider.enabled = false; 
        }
    }
}
