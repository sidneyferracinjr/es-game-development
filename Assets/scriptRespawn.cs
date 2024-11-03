using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptRespawn : MonoBehaviour
{
    public GameObject inimigo;
    private float largura;
    // Start is called before the first frame update
    void Start()
    {
        largura = Camera.main.orthographicSize * Camera.main.aspect;
        InvokeRepeating("respawnar", 0, 1);
    }

    private void respawnar()
    {
        float posX;
        posX = Random.Range(-largura, largura);
        Instantiate(inimigo, new Vector2(posX, 5), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
