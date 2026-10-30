using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perigo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.CompareTag("Player"))
        {
            VidaJogador vida = outro.GetComponent<VidaJogador>();
            if (vida != null)
            {
                vida.dano();
            }

        }
    }
}