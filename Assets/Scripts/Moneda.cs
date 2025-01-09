using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public float speed;
    Vector3 navepos;
    Vector3 monedapos;
    GameObject nave;
    

    // Start is called before the first frame update
    void Start()
    {
        nave = GameObject.Find("Nave");
      
    }

    // Update is called once per frame
    void Update()
    {
        navepos = nave.transform.position;
        monedapos = transform.position;

        if (transform.position.y == transform.position.y -5)
        {
            print("arriba");
            transform.Translate(Vector3.up * speed);
            
        }

        if (transform.position.y == transform.position.y + 5)
        {
            print("abajo");
            transform.Translate(Vector3.down * speed);
            
        }

        float dist = Vector3.Distance (navepos, transform.position);

        if (dist < 20)
        {
            transform.Rotate(0,transform.rotation.y + 1 * speed,0);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
