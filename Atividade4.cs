using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atividade4 : MonoBehaviour
{
    public List<Transform> points;//waypoints(movimentação dos pontos)
    public int pontoAtual = 0;
    public int pontoReferencia = 1;
    public float t = 0;// lerp
    public bool movimentacaoFinalizada=false;//validei a movimentaçao
    public Material cor;//material, utilizado pra mudar as cores
    void Start()
    {
        this.transform.position = points[pontoAtual].position;//Ponto atual
    }

    // Update is called once per frame
    void Update()
    {
        Movimentacao(); //chama o metodo
    }
    private void Movimentacao()
    {
        t = t + Time.deltaTime;//

        Vector3 newPoint = Vector3.Lerp(points[pontoAtual].position, points[pontoReferencia].position, t);//fazendo a movimentação linear(Lerp)

        this.transform.position = newPoint; // novo ponto
        if (t >= 1)//Quando for maior ou igual a 1, chega ao ponto de referencia
        {
            points[pontoReferencia].GetComponent<MeshRenderer>().material=cor;//troca a cor com o material
            t = 0;//reseta o t
            pontoAtual = pontoReferencia;//meu ponto atual passa a ser o ponto de referencia

            if (pontoReferencia == points.Count - 1)//chequei se meu ponto de Referencia era o ultimo da lista
            {
                pontoReferencia --;//para voltar no penultimo
                movimentacaoFinalizada = true;//se for verdade, finaliza 
            }
            else if(movimentacaoFinalizada==false)//se não terminei de movimentar, continua movimentando
            {
                pontoReferencia++;//senão for o ultimo, passa a ser o proximo da lista.
            }
        }


    }
}
