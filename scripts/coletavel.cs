using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coletavel : MonoBehaviour
{
    public int valor = 10;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Gerenciador placar = FindObjectOfType<Gerenciador>();
        if (placar != null)
        {
            placar.adicionarPontos(valor);
        }
        Destroy(gameObject);

    }

}
