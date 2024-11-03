using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
{
    private float altura;
    private float largura;
    private Rigidbody2D rbd;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
       rbd = GetComponent<Rigidbody2D>();
       speed = 10f;
       altura = Camera.main.orthographicSize;
       largura = altura * Camera.main.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        rbd.velocity = new Vector2(x, y) * speed;

        if (transform.position.x > largura){
            transform.position = new Vector2(-largura, transform.position.y);;
        }
        else if (transform.position.x < -largura){
            transform.position = new Vector2(largura, transform.position.y);
        }

        if (transform.position.y > altura){
            transform.position = new Vector2(transform.position.x, altura);
        }
        else if (transform.position.y < -altura){
            transform.position = new Vector2(transform.position.x, -altura);
        }
    }
}
