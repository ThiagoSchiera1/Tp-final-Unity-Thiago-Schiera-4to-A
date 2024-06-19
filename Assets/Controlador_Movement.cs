using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Controlador_Movement : MonoBehaviour
{

    public GameObject[] Objetos;
    public int Indice;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Objetos.Length; i++)
        {
            Objetos[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Objetos [Indice +=1].SetActive(false);
            Objetos [Indice -=1 ].SetActive(true);
            Indice++;

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            Objetos[Indice +=1].SetActive(true);
            Objetos[Indice -=1].SetActive(true);
        }
    }
    
}
