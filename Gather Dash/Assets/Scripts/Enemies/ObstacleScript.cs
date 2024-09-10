using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    [SerializeField] private Sprite optionOne, optionTwo, optionThree;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        int spriteChoice = Random.Range(1, 3);

        switch (spriteChoice)
        {
            case 1:
                spriteRenderer.sprite = optionOne;
                break;
            case 2:
                spriteRenderer.sprite = optionTwo;
                break;
            case 3:
                spriteRenderer.sprite = optionThree;
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Border"))
        {
            Destroy(gameObject);
        }
    }
}
