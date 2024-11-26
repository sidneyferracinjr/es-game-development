using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptNpc : MonoBehaviour
{
    public float speed = 2.0f;
    private Rigidbody2D rbd;

    private void OnTriggerEnter2D(Collider2D col)
    {
        scriptPlacar.incrementarPlacar(1);
        Destroy(gameObject);
        Destroy(col.gameObject);
    }

    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        rbd.velocity = new Vector2(0, -speed);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -Camera.main.orthographicSize)
        {
            Destroy(gameObject);
        }
    }
}
