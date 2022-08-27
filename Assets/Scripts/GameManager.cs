using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if(_instance == null)
            {
                UnityEngine.Debug.LogError("GameManager is null");
            }

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }
}
