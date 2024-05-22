using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chao : MonoBehaviour
{
    [SerializeField]
    private float velocidade;

    private Vector3 posicaoInicial;
    private float tamanhoImagemNaCena;

    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        float tamanhoImagemReal = GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoImagemNaCena = tamanhoImagemReal * escala;
    }

    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, tamanhoImagemNaCena);
        this.transform.position = posicaoInicial + Vector3.left * deslocamento;
    }
}
