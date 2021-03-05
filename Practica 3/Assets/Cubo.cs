using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : Interactable
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        base.Update();
    }

    public override void Interact()
    {
        Destroy (this.gameObject, 1);
    }
}
