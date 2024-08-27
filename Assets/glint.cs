using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glint : MonoBehaviour
{
    public GameObject glintParticle;
    private float counter = 0;

    void Start()
    {
        
    }

    void Update()
    {
        counter += Time.deltaTime;
        if(counter >= 1.4) {
            counter = 0;
        }
    }
}
