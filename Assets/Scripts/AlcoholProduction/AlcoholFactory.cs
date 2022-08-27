using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AlcoholFactory : MonoBehaviour
{
    public string factoryName = string.Empty;
    public int alcoholProduction = 1;
    public int productionTime = 1;

    private TextMeshProUGUI nameTextObject;
    private TextMeshProUGUI productionTextObject;
    private TextMeshProUGUI productionTimeTextObject;

    void Start()
    {
        nameTextObject = gameObject.transform.Find("NameText").GetComponent<TextMeshProUGUI>();
        nameTextObject.text = factoryName;
        productionTextObject = gameObject.transform.Find("ProductionText").GetComponent<TextMeshProUGUI>();
        productionTextObject.text = $"Tuotanto: {alcoholProduction} annosta";
        productionTimeTextObject = gameObject.transform.Find("ProductionTimeText").GetComponent<TextMeshProUGUI>();
        productionTimeTextObject.text = $"Nopeus: {productionTime} s";

        InvokeRepeating("ProduceAlcohol", productionTime, productionTime);
    }

    void ProduceAlcohol()
    {
        ResourceManager.Instance.AddAlcohol(alcoholProduction);
    }
}
