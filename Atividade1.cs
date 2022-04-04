using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atividade1 : MonoBehaviour
{
    
    public Transform pointStart; //O transform � utilizado para definir a posi��o, o PointStart � o ponto que inicia.
    public Transform pointFinish;//Ponto que termina.
    public float t;//tempo em float, em numeros d�cimais.
    
    void Start()
    {
        //
    }

    void Update()
    {
        t = t + Time.deltaTime;
        Vector3 newPoint = Vector3.Lerp(pointStart.position, pointFinish.position, t);
        //Vextor3 recebe o resultado do m�todo Lerp(que seria uma interpola��o linear de algum valor), passa pelo parametro do pointStart, pointFinish, e t)
        this.transform.position = newPoint; // posicionamento do novo ponto.

       
    
    }
}
