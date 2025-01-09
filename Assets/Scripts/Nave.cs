using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using OpenCover.Framework.Model;
using UnityEngine;

public class Nave : MonoBehaviour
{

    public float speed = 0.1f;
    public float maxSpeed = 0;
    public float minSpeed = 0;

    public float temporizadorAcelerar = 10;

    public Renderer motorDerecho;
    public Renderer motorIzquierdo;

    //private Color colorOriginal;

    private bool acelerando = false;

    public Manager game;

    private void Awake()
    {
       // colorOriginal = motorDerecho.material.color;
        maxSpeed = speed * 2;
        minSpeed = speed;
    }

    void FixedUpdate()
    {
         applyRotation();
         applyMovement();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && acelerando == false)
        {
            print("acelarado");
            acelerando = true;
            speed = 0.8f;
        }
        else if (acelerando == true)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                acelerando = false;
                speed = 0.5f;
            }
        }
    }

    private void applyMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed);
        } else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * speed);
        }


        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed);
        } else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed);
        }
    }

    private void applyRotation()
    {

        float sumarX = 0;
        float sumarY = 0;
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            sumarY = 1;
        } else if (Input.GetKey(KeyCode.DownArrow))
        {
            sumarY = -1;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            sumarX = 1;
        } else if (Input.GetKey(KeyCode.LeftArrow))
        {
            sumarX = -1;
        }

        transform.eulerAngles = new Vector3(
            transform.eulerAngles.x + sumarY,
            transform.eulerAngles.y + sumarX,
            transform.eulerAngles.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("moneda"))
        {
            game.ContadorMonedas();
        }
    }
}
