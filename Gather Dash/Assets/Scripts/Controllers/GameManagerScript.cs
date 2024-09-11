using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManagerScript : MonoBehaviour
{
    public float gameSpeed, runScore, collectables;
    [SerializeField] private GameObject endGameUI;
    [SerializeField] private TMP_Text collected, multiplier, total;
    [SerializeField] private BackgroundControllerScript bgOne, bgTwo, bgThree, ground;
    public MainPlayerScript player;
    private float multiplied = 1;
    private bool gameOver;
    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            transform.position += new Vector3(gameSpeed * Time.deltaTime, 0, 0);

            if (player.dead)
            {
                gameOver = true;

                bgOne.bgSpeed = 0;
                bgTwo.bgSpeed = 0;
                bgThree.bgSpeed = 0;
                ground.bgSpeed = 0;

                multiplied += runScore / 100;
                float totalCollected = collectables * multiplied;

                gameSpeed = 0;

                endGameUI.SetActive(true);

                collected.SetText(collectables.ToString());
                multiplier.SetText(multiplied.ToString("F2"));
                total.SetText(totalCollected.ToString("F2"));
            }
            else
            {
                runScore += Time.deltaTime;
            }
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToBase()
    {
        SceneManager.LoadScene("Central Base");
    }
}