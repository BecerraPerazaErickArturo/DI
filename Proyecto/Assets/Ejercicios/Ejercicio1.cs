using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int Metodo(int[] numeros, int tam) {
        int res = 0, aux = 0;
        for (int i = 0; i < tam; i++)
        {
            aux = numeros[i];
            while (((aux % 2) == 0) && aux > 10)
            {
                    if ((aux % 2) == 0)
                        aux = aux / 2;
            }
                if ((aux % 2) == 0)
                    res++;
        }
        return res;
    }
}
