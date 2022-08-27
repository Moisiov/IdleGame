using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Common.Enums;
using TMPro;

public class ResourceText : MonoBehaviour
{
    public string text = string.Empty;
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
            textObject.text = text + ResourceManager.Instance.GetResourceText(resource);
        }
    }
}
