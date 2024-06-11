using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameOfParent : MonoBehaviour
{

    public TextMeshPro TheText;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        print("Changing it to :" + transform.parent.parent.name);
        TheText.text = "I am " + transform.parent.parent.name;
    }
}
