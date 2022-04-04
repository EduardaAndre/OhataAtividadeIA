using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atividade1 : MonoBehaviour
{
    
    public Transform pointStart; //O transform é utilizado para definir a posição, o PointStart é o ponto que inicia.
    public Transform pointFinish;//Ponto que termina.
    public float t;//tempo em float, em numeros décimais.
    
    void Start()
    {
        //
    }

    void Update()
    {
        t = t + Time.deltaTime;
        Vector3 newPoint = Vector3.Lerp(pointStart.position, pointFinish.position, t);
        //Vextor3 recebe o resultado do método Lerp(que seria uma interpolação linear de algum valor), passa pelo parametro do pointStart, pointFinish, e t)
        this.transform.position = newPoint; // posicionamento do novo ponto.

       
    
    }
}
