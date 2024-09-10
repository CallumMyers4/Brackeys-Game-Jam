using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundControllerScript : MonoBehaviour
{
    [SerializeField] public float bgSpeed;
    private Renderer bgRenderer;

    void Start()
    {
        bgRenderer = GetComponent<MeshRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        bgRenderer.material.mainTextureOffset += new Vector2(bgSpeed * Time.deltaTime, 0);
    }
}
