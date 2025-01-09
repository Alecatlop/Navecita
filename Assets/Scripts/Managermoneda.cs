using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.tvOS;

public class Managermoneda : MonoBehaviour
{
    public GameObject prefab;
    public GameObject[] lista25;
    public GameObject[] lista15;

    int n = 0;
    int n2 = 0;

    int[] checkLista25 = new int[25];
    int[] checkLista15 = new int[15];

    // Start is called before the first frame update
    void Start()
    {
        // RELLENAR LA LISTA A 0
        for (int i = 0; i < checkLista25.Length; i++)
            checkLista25[i] = 0;

        
        for (int a = 0; a < 15; a++)
        {
            // crea un numero aleatorio y compara si se ha tirado ya una vez
            do
            {
               n = Random.Range(0, lista25.Length);
            }
            //si coincide repite
            while (checkLista25[n] == 1);

            //y sino instancia
            checkLista25[n] = 1;

            GameObject spawn = lista25[n];

            Instantiate(prefab);
            prefab.transform.position = spawn.transform.position;
        }



        for (int b = 0; b < checkLista15.Length; b++)
            checkLista15[b] = 0;

        for (int c = 0; c < 5; c++)
        {
            do
            {
                n2 = Random.Range(0, lista15.Length);
            }
            while (checkLista15[n2] == 1);

            checkLista15[n2] = 1;

            GameObject spawn2 = lista15[n2];

            Instantiate(prefab);
            prefab.transform.position = spawn2.transform.position;
        }

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
