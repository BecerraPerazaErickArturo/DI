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

    public int[] SumaDos(int[] nums, int target) {
        int[] resultado = new int[2];
        for (int i = 0; i < nums.Length; i++)
            for (int j = 0; j < nums.Length; j++) {
                if (i != j)
                    if ((nums[i] + nums[j]) == target) {
                        resultado[0] = i;
                        resultado[1] = j;
                    }
            }
        return resultado;
    }
}
