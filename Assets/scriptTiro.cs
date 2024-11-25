using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptTiro : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidade = 10;
    // Start is called before the first frame update
    void Start()
    {
        velocidade = 10;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, velocidade);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > Camera.main.orthographicSize)
        {
            Destroy(gameObject);
        }
    }
}
