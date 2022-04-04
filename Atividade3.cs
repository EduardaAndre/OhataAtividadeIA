using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atividade3 : MonoBehaviour
{
    public Transform Referencia; // ponto de referência.
    public float speed; // velocidade em números décimais.
  

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentacaoObjeto();//chama o método 
     
    }
    private void MovimentacaoObjeto()
    {
        Vector3 direcao;
        direcao = Referencia.position - this.transform.position; //direção para a posição do ponto alvo.
        direcao = direcao.normalized;// ira fazer com que a magnitude seja 1.
        transform.Translate(direcao * speed);//movimenta o objeto na direção do alvo com uma velocidade.

    }
 
}
