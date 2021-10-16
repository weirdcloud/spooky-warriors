using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHideMainAndShowLvlChoiceMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject[] mainMenu;
    [SerializeField]
    private GameObject[] lvlChoiceMenu;

    public void HideMainAndShowLvlChoice()
    {
        foreach (GameObject element in mainMenu)
        {
            element.SetActive(false);
        }
        foreach (GameObject element in lvlChoiceMenu)
        {
            element.SetActive(true);
        }
    }
}
