using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public float gameSpeed;
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(gameSpeed * Time.deltaTime, 0, 0);
    }
}
