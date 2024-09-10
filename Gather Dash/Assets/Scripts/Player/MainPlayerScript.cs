using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainPlayerScript : MonoBehaviour
{
    public bool dead;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            //SceneManager.LoadScene("Forest Runner");
            Destroy(other.gameObject);
            //dead = true;
        }
    }
}
