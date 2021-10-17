using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlOneManager : MonoBehaviour
{
    [SerializeField]
    private GameObject winUI;
    [SerializeField]
    private GameObject loseUI;

    private void Awake()
    {
        winUI.SetActive(false);
        loseUI.SetActive(false);
    }
    private void Update()
    {

        if (FindObjectsOfType<PumpkinSpawnerHealthManager>().Length == 0)
        {
            winUI.SetActive(true);
        }
    }
    public void OnPlayerDeath()
    {
        loseUI.SetActive(true);
    }
}
