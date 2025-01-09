using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public TextMeshProUGUI tiempo;
    public TextMeshProUGUI monedas;
    public TextMeshProUGUI arcos;
    public TextMeshProUGUI puntuacion;
    public TextMeshProUGUI monedas2;
    public TextMeshProUGUI arcos2;
    float numtiempo = 30;
    int nummonedas = 0;
    int numarcos = 10;
    GameObject Derrota;
    GameObject Victoria;
    float puntos = 0;
    GameObject estadisticas;


    // Start is called before the first frame update
    void Start()
    {
        Derrota = GameObject.Find("Derrota");
        Victoria = GameObject.Find("Victoria");
        estadisticas = GameObject.Find("Estadísticas");

        Victoria.SetActive(false);
        Derrota.SetActive(false);
        estadisticas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (numtiempo > 0)
        {
            numtiempo -= Time.deltaTime;
            tiempo.text = "" + (int)numtiempo;
        }
        else
        {
            numtiempo = 0;
            tiempo.text = "" + (int)numtiempo;
            puntos = numtiempo + nummonedas * 2;
            puntuacion.text = "Puntuación: " + (int)puntos;
            monedas.text = "Monedas: " + nummonedas;
            arcos.text = "Arcos: " + numarcos;
            monedas2.text = "Monedas: " + nummonedas;
            arcos2.text = "Arcos: " + (10 - numarcos);
            estadisticas.SetActive(true);
            Derrota.SetActive(true);
        }

        if (numarcos == 0)
        {
            Time.timeScale = 0;
            tiempo.text = "" + (int)numtiempo;
            puntos = numtiempo + nummonedas * 2;
            puntuacion.text = "Puntuación: " + (int)puntos;
            monedas.text = "Monedas: " + nummonedas;
            arcos.text = "Arcos: " + numarcos;
            monedas2.text = "Monedas: " + nummonedas;
            arcos2.text = "Arcos: " + (10 - numarcos);
            estadisticas.SetActive(true);
            Victoria.SetActive(true);
        }
    }

    public void ContadorMonedas()
    {
        nummonedas++;
        monedas.text = "Monedas: " + nummonedas;
    }

    public void ContadorArcos()
    {
        numarcos--;
        arcos.text = "Arcos: " + numarcos;
    }
}