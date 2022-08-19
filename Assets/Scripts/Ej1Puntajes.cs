using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1Puntajes : MonoBehaviour
{
    public int[] puntajes = new int [10];

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(ObtenerMayorPuntaje());
        Debug.Log(ObtenerMenorPuntaje());
        Debug.Log(ObtenerPuntajePromedio());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int ObtenerMayorPuntaje()
    {

        int MayorPuntaje = 0;

        foreach (int puntaje in puntajes)
        {
            if(puntaje > MayorPuntaje)
            {
                MayorPuntaje = puntaje;
            }
        }
        return MayorPuntaje;
    }


    int ObtenerMenorPuntaje()
    {
        int ObtenerMenorPuntajes = 0;
        int menorPuntaje = puntajes[0];
        for(int i= 0; i<puntajes.Length; i++)
        {
            if(puntajes[i] < menorPuntaje)
            {
                menorPuntaje = puntajes[i];
                ObtenerMenorPuntajes = i;
            }

        }
        return ObtenerMenorPuntajes;
    }

    float ObtenerPuntajePromedio()
    {

        float promedio = 0;

        float suma = 0;
        foreach(int num in puntajes)
        {
            suma += num;
        }
        promedio = suma / puntajes.Length;

        return promedio;
    }
}
