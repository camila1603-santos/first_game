using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gerenciador : MonoBehaviour
{

    public TMP_Text textoPlacar;
    private int pontuacao = 0;

    // Start is called before the first frame update
    void Start()
    {
        atualizarTexto();
    }

    public void adicionarPontos(int valor)
    {
        pontuacao += valor;
        atualizarTexto();
    }

    void atualizarTexto()
    {
        if (textoPlacar != null)
        {
            textoPlacar.text = "Pontos: " + pontuacao;
        }
    }

}
