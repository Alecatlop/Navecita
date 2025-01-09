using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerAros : MonoBehaviour
{
    public Manager texto;
    public GameObject[] listaros;
    int a = 0;

    // Start is called before the first frame update
    void Start()
    {
        listaros[a].GetComponent<MeshRenderer>().material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Cambiocolor()
    {
        listaros[a].GetComponent< MeshRenderer >().material.color = Color.red;
      
        if (a < 9)
        {
            a++;
            listaros[a].GetComponent<MeshRenderer>().material.color = Color.green;
            texto.ContadorArcos();
        }
        else
        {
            a++;
            texto.ContadorArcos();
        }
       
    }
}
