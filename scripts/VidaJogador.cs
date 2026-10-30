using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidaJogador : MonoBehaviour
{

    public int vidas = 3;
    public TMP_Text textoVidas;
    private float invulneravelAte = 0f;

    // Start is called before the first frame update
    void Start()
    {
        atualizarTexto();
        
    }
    
    public void dano()
    {
        if (Time.time < invulneravelAte || vidas <= 0)
            return;

        vidas--;
        invulneravelAte = Time.time + 1f;
        atualizarTexto();

        if(vidas <= 0 )
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void atualizarTexto()
    {
        if(textoVidas != null)
        {
            textoVidas.text = "Vidas: " + vidas;
        }
    }
}
