using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorZumbis : MonoBehaviour
{
    //variaveis e objetos
    public float delay = 2.0f;
    public GameObject zumbiPrefab;
    private float area = 3.0f;

    private void Start()
    {
        //chama um metodo repetidamente por determinado tempo
        InvokeRepeating("GerarZumbi", delay, delay);
    }

    void GerarZumbi()
    {
        //instanciando o prefab do zumbi
        GameObject zumbi = Instantiate(zumbiPrefab);
        //criando um vector 2 (x, y) em área de um circulo, e multiplicando para aumentar o raio
        Vector2 posicaoAleatoria = Random.insideUnitCircle * area;
        //criar um vector 3 de localização do zumbi dentro do raio permitido pelo circulo
        zumbi.transform.position = new Vector3(posicaoAleatoria.x, zumbi.transform.position.y, posicaoAleatoria.y);

    }
}