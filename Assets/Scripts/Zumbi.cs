using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zumbi : MonoBehaviour
{
    private Animator anim;
    private Rigidbody rb;

    public float vel = 0.35f;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Movimentacao();
    }

    private void OnTriggerEnter(Collider col)
    {
        //print("other is overlapping");

        //compara se o tag do que atinge o Trigger é igual a do projetil, se for, destroi o projetil
        //e o player
        if (col.CompareTag("proj"))
        {
            Destroy(col.gameObject);
            //Destroy(gameObject);

            //set no Animator o trigger de morrer como verdadeiro
            anim.SetTrigger("Morrer");
        }
    }

    //movimentação do zumbi com proprio metodo
    private void Movimentacao()
    {
        //o transform pega a rotação do zumbi, enquanto o Vector3 pega a a rotação do do mundo
        rb.velocity = transform.forward * vel;
    }
}