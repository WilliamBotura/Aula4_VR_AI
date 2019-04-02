using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zumbi : MonoBehaviour
{
    private Animator anim;
    private Rigidbody rb;
    GameObject jogador;

    public float vel = 0.35f;
    bool morto = false;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        jogador = GameObject.FindGameObjectWithTag("Player");
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
        if (!morto && col.CompareTag("proj"))
        {
            Destroy(col.gameObject);
            //Destroy(gameObject);

            Morrer();
        }
    }

    private void Morrer()
    {
        //set no Animator o trigger de morrer como verdadeiro
        anim.SetTrigger("Morrer");

        morto = true;
    }

    //movimentação do zumbi com proprio metodo
    private void Movimentacao()
    {
        //o transform pega a rotação do zumbi, enquanto o Vector3 pega a a rotação do do mundo
        if (!morto)
        {
            //move o zumbi
            rb.velocity = transform.forward * vel;
            //zumbu sempre olha para o jogador
            transform.LookAt(jogador.transform);
        }

    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            //armazena em uma variavel a cena atual
            Scene currentScene = SceneManager.GetActiveScene();
            //mudado para o scene manager a partir do alt+enter, 
            SceneManager.LoadScene(currentScene.buildIndex);
        }
    }
}