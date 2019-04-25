using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle : MonoBehaviour
{
    public const int linha = 14;
    public const float setX = 0.8f;
    [SerializeField] private CartaComp cartaoriginal;
    [SerializeField] private Sprite[] imagens;

    private void Start()
    {
        Vector3 startPos = cartaoriginal.transform.position;

        for (int i= 0; i < linha; i++)
        {
            CartaComp card;
            if (i == 0)
            {
                card = cartaoriginal;
            }
            else
            {
                card = Instantiate(cartaoriginal) as CartaComp;
            }
            float posX = (setX * i) + startPos.x;
            card.transform.position = new Vector3(posX, startPos.y, startPos.z);
        }
    }

}
