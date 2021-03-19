using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int metodo(int[] numeros, int tam) {
        int res = 0, aux = 0;
        for (int i = 0; i < tam; i++)
        {
            for (int j = 0; j < tam; j++)
            {
                if (numeros[i] != numeros[j])
                    aux++;
            }
            if (aux == tam)
            {
                res = numeros[i];
                return res;
            }
            aux = 0;
        }
        return res;
    }
}
