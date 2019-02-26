using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proj_scrip : MonoBehaviour
{
    [Range(1, 7)]
    public float vel = 2.5f;

    private void Start()
    {
    }

    private void Update()
    {
        var direcao = Vector3.forward * vel * Time.deltaTime;
        transform.Translate(direcao, Space.Self);
    }
}