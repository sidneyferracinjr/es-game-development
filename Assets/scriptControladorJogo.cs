using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptControladorJogo : MonoBehaviour
{
    private bool pausa;
    // Start is called before the first frame update
    void Start()
    {
        pausa = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(pausa)
            {
                Time.timeScale = 1;
                SceneManager.UnloadSceneAsync(0);
            }
            else
            {
                Time.timeScale = 0;
                SceneManager.LoadSceneAsync(0,LoadSceneMode.Additive);
            }
            pausa = !pausa;
        }
    }
}
