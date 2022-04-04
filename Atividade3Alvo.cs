using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atividade3Alvo : MonoBehaviour
{
    public List<Transform> points;//movimentação dos pontos
    public int pontoAtual=0;
    public int pontoReferencia=1;
    public float t = 0;// Onde será feito o Lerp
    void Start()
    {
        this.transform.position = points[pontoAtual].position;//Primeiro ponto
    }

    // Update is called once per frame
    void Update()
    {
        MovimentacaoAlvo(); //chama o método
    }
    private void MovimentacaoAlvo()
    {
        t = t + Time.deltaTime;

        Vector3 newPoint = Vector3.Lerp(points[pontoAtual].position, points[pontoReferencia].position, t);//fazendo a movimentação, utilizando o Lerp(interpolação linear).

        this.transform.position = newPoint; // novo ponto
        if (t >= 1)//Quando for maior ou igual a 1, chega ao ponto de referencia
        {
            t = 0;//reseta o t
            pontoAtual = pontoReferencia;//ponto inicial vira o ponto de referencia
           
            if (pontoReferencia == points.Count - 1)//é o ultimo da lista?
            {
                pontoReferencia = 0;//se ele for o ultimo ponto da lista, ele passa a ser o primeiro
            }
            else
            {
                pontoReferencia++;//senão for o ultimo, passa a ser o proximo da lista.
            }
        }


    }
}
