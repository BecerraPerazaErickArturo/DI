using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	int[] arreglo = new int[5] {9, 8, 7, 6, 5};
	int[] recibidor = new int[5];
	int i = 0, j = 0, aux = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	//Problema:
	void Problema(){
		for(i = 0; i < 5; i++){
			for(j = 0; j < 5; j++){
				if(arreglo[i] > arreglo[j]){
					aux++;
				}
			}
				recibidor[i] = aux;
				aux = 0;
		}
	}
}
