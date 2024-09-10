using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    private Rigidbody2D playerRB;
    private Animator playerAnimator;
    public bool midair = false;
    private bool sliding = false;
    [SerializeField] private int jumpPower;
    [SerializeField] private float slideTime;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        playerAnimator.SetBool("Midair", midair);
        playerAnimator.SetBool("Sliding", sliding);

        if (Input.GetKeyDown(KeyCode.S) && !sliding)
        {
            StartCoroutine(Slide());
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //jump
        if (Input.GetKeyDown(KeyCode.Space) && !midair)
        {
            playerRB.AddForce(new Vector2(playerRB.velocity.x, jumpPower));
            midair = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            midair = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            midair = true;
        }
    }

    private IEnumerator Slide()
    {
        sliding = true;
        transform.eulerAngles = new Vector3(0, 0, 90);
        transform.localScale = new Vector3(0.7f, 1, 1);
        playerAnimator.speed = 0;
        yield return new WaitForSeconds(slideTime);
        playerAnimator.speed = 1;
        transform.eulerAngles = new Vector3(0, 0, 0);
        transform.localScale = new Vector3(1, 1, 1);
        sliding = false;
    }
}
