using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverallGameManagerScript : MonoBehaviour
{
    public static OverallGameManagerScript globalManager { get; private set; } // Singleton instance
    public int woodCollected, stoneCollected, soulsCollected;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        globalManager = this;
    }

    public void ChangeWoodAmount(int wood)
    {
        woodCollected += wood;
    }

    public void ChangeStoneAmount(int wood)
    {
        woodCollected += wood;
    }
}
