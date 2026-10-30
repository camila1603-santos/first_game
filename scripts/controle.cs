using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controle : MonoBehaviour
{

    public float velocidade = 5f;
    public float forcaDoPulo = 8f;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private bool noChao = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Lê o movimento e altera a velocidade horizontal
        float movimento = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movimento * velocidade, rb.velocity.y);

        //Vira o sprite flipx false -> direita ; true -> esquerda
        if (sprite != null)
        {
            sprite.flipX = movimento < 0;
        }

        //Lê o comando de pulo
        if (Input.GetKeyDown(KeyCode.Space) && noChao)
        {
            rb.velocity = new Vector2(rb.velocity.x, forcaDoPulo);
        }
    }

    void OnCollisionEnter2D(Collision2D outro)
    {
            if (outro.gameObject.CompareTag("Chao"))
        {
            noChao = true;
        }       
    }

     void OnCollisionExit2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("Chao"))
        {
            noChao = false;
        }
    }
}
    