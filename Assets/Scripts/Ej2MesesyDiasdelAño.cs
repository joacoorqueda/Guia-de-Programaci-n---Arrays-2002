﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2MesesyDiasdelAño : MonoBehaviour
{

    [SerializeField] string[] nombresmeses = new string[12];
    [SerializeField] int[] diasporcadames = new int[12];
    public string FechaIngresada;

    // Start is called before the first frame update
    void Start()
    {
        ValidarFormatoFecha(FechaIngresada);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool ValidarFormatoFecha(string fecha)
    {
        bool Fechavalida = false;

        if (fecha.Length == 4)
        {
            string dia = "";
            string mes = "";

            dia += fecha[0];

            dia += fecha[1];

            int diaNumber = int.Parse(dia);

            Debug.Log(dia);

            mes += fecha[2];
            mes += fecha[3];
            int mesNumber = int.Parse(mes);

            if(diaNumber >0 && diaNumber<=31 && mesNumber >0 && mesNumber <= 12)
            {
                Fechavalida = true;
            }
        }
        else
        {
            Debug.Log("El largo de la fecha es incorrecto");
        }

        return Fechavalida;
    }
}
