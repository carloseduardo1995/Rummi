using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Regressiva : MonoBehaviour
{
    public Text display;
    public float contador = 30;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (contador > 0)
        {
            contador -= Time.deltaTime;
            display.text = contador.ToString("f0");
        }
    }
}
