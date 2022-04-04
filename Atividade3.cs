using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atividade3 : MonoBehaviour
{
    public Transform Referencia; // ponto de refer�ncia.
    public float speed; // velocidade em n�meros d�cimais.
  

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentacaoObjeto();//chama o m�todo 
     
    }
    private void MovimentacaoObjeto()
    {
        Vector3 direcao;
        direcao = Referencia.position - this.transform.position; //dire��o para a posi��o do ponto alvo.
        direcao = direcao.normalized;// ira fazer com que a magnitude seja 1.
        transform.Translate(direcao * speed);//movimenta o objeto na dire��o do alvo com uma velocidade.

    }
 
}
