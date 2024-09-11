using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainPlayerScript : MonoBehaviour
{
    [SerializeField] private GameManagerScript runnerController;
    public bool dead;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Destroy(other.gameObject);
            dead = true;
        }

        if (other.gameObject.CompareTag("Collectable"))
        {
            runnerController.collectables += 1;
        }
    }
}
