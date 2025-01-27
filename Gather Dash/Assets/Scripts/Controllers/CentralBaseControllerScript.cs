using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class CentralBaseControllerScript : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI woodDisplay;
    // Start is called before the first frame update
    void Start()
    {
        woodDisplay.text = "Wood:" + OverallGameManagerScript.globalManager.woodCollected;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("Forest Runner");
        }
    }
}
