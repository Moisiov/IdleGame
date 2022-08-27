using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;

public class NavButton : MonoBehaviour
{
    public GameObject gameWindows;

    public void Navigate(GameObject targetWindow)
    {
        targetWindow.SetActive(true);

        foreach (Transform window in gameWindows.transform)
        {
            if (window.gameObject != targetWindow) window.gameObject.SetActive(false);
        }
    }
}
