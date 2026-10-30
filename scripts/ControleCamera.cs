using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleCamera : MonoBehaviour
{
    public Transform jogador;
    public float suavizacao = 5f;
    public Vector3 deslocamento = new Vector3(0f, 1f, -10f);

    // Start is called before the first frame update
    void Start()
    {
        if(jogador == null)
        {
            GameObject objetoJogador = GameObject.FindGameObjectWithTag("Player");
                if(objetoJogador != null )
            {
                jogador = objetoJogador.transform;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (jogador == null)
            return;

        Vector3 posicaoDesejada = jogador.position + deslocamento;
        transform.position = Vector3.Lerp(transform.position, posicaoDesejada, suavizacao * Time.deltaTime);
    }
}
