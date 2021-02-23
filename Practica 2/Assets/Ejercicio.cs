using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Ejercicio:
    bool Retorno(string[] Array, string Nom, int NumAlumnos){
        for (int i = 0; i < NumAlumnos; i++)
            if (Array[i] == Nom)
                return true;
        return false;
    }
}
