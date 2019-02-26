using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    [Header("Atirar")]
    [Tooltip("Prefab do projeto que instanciado")]
    public GameObject projetilPrefab;

    private void Start()
    {
    }

    private void Update()
    {
        var botaoTrue = Input.GetMouseButtonDown(0);

        if (botaoTrue)
        {
            Atirar();
        }
    }

    private void Atirar()
    {
        var projetil = Instantiate(projetilPrefab);
        projetil.transform.position = Camera.main.transform.position;
        projetil.transform.rotation = Camera.main.transform.rotation;
    }
}