using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scriptPlacar : MonoBehaviour
{
    private static int placar = 0;
    private static GameObject txtPlacar;

    public void Start()
    {
        placar = 0;
        txtPlacar = GameObject.Find("txtPlacar");
    }

    public static void incrementarPlacar(int a)
    {
        placar += a;
        txtPlacar.GetComponent<TMP_Text>().text = "Placar: " + placar;
    }
}
