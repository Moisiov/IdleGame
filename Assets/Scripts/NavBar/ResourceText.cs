using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Game.Common.Enums;
using TMPro;
using Game;

public class ResourceText : MonoBehaviour
{
    public Resource resource = Resource.Alcohol;
    private TextMeshProUGUI textObject;

    private void Start()
    {
        textObject = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (textObject != null)
        {
            switch (resource)
            {
                case Resource.Alcohol:
                    textObject.text = $"Alkoholi: {ResourceManager.Instance.GetAlcohol()}";
                    break;
                case Resource.Money:
                    textObject.text = $"Raha: {ResourceManager.Instance.GetMoney()} €";
                    break;
                case Resource.Intoxication:
                    textObject.text = $"Humala: {ResourceManager.Instance.GetIntoxication():0.00} ‰";
                    break;
                default:
                    break;
            }
        }
    }
}
