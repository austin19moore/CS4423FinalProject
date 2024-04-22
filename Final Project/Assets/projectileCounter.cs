using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileCounter : MonoBehaviour
{

    public int counter = 0;
    public void Increment()
    {
        this.counter += 1;
    }

    public int GetCount() {
        return this.counter;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
