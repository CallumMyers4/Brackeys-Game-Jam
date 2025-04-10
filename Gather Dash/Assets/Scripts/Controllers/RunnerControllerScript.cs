using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerControllerScript : MonoBehaviour
{
    [SerializeField] public float cameraSpeed;

    void Update()
    {
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
    }
}
