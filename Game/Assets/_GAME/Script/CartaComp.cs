using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartaComp : MonoBehaviour
{
    private Vector3 posicaoini;
    private int cont = 0;
    private int cont1 = 0;
    private Vector3 StartPos;
    private Vector3 recebePos;
    void OnMouseDown()
    {
        if (cont1 == 0)
        {
            StartPos = transform.position;
            transform.position = posicaocarta(new Vector3(0, 0, 0));
            cont1++;
        }
        else
        {
            transform.position = StartPos;
            cont1 = 0;
        }
    }
    private Vector3 posicaocarta(Vector3 alvo)
    {
        if (alvo != recebePos)
        {
            return alvo;
        }
        else
        {
            cont++;
            float posX = (cont * 1f) + alvo.x;
            return new Vector3(posX, alvo.y, alvo.z);
        }
    }
}
