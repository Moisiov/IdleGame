using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Common.Enums;

public class ResourceManager : MonoBehaviour
{
    private static ResourceManager _instance;

    private int _alcohol = 0;
    private int _money = 0;
    private float _intoxication = 0f;

    public static ResourceManager Instance
    {
        get
        {
            if (_instance == null)
            {
                UnityEngine.Debug.LogError("ResourceManager is null");
            }

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public int GetAlcohol()
    {
        return _alcohol;
    }

    public void AddAlcohol(int alcohol)
    {
        _alcohol += alcohol;
    }

    public int GetMoney()
    {
        return _money;
    }

    public void AddMoney(int money)
    {
        _money += money;
    }

    public float GetIntoxication()
    {
        return _intoxication;
    }

    public void AddIntoxication(float intoxication)
    {
        _intoxication += intoxication;
    }
}
