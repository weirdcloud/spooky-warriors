using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHideLvlChoiceAndShowMainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject[] mainMenu;
    [SerializeField]
    private GameObject[] lvlChoiceMenu;

    public void HideLvlChoiceAndShowMain()
    {
        foreach (GameObject element in mainMenu)
        {
            element.SetActive(true);
        }
        foreach (GameObject element in lvlChoiceMenu)
        {
            element.SetActive(false);
        }
    }
}
