using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlcoholFactory : MonoBehaviour
{
    public int alcoholProduction = 1;
    public int productionTime = 1;

    void Start()
    {
        InvokeRepeating("ProduceAlcohol", productionTime, productionTime);
    }

    void ProduceAlcohol()
    {
        ResourceManager.Instance.AddAlcohol(alcoholProduction);
        UnityEngine.Debug.Log($"{alcoholProduction} alcohol produced");
    }
}
