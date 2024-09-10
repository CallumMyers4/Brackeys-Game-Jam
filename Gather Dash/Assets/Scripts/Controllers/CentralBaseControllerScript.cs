using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CentralBaseControllerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("Forest Runner");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
