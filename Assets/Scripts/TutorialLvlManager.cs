using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialLvlManager : MonoBehaviour
{
    [SerializeField]
    private GameObject toMenuUI;

    private void Awake()
    {
        toMenuUI.SetActive(false);
    }
    private void Update()
    {
        
        if (FindObjectsOfType<PumpkinSpawnerHealthManager>().Length == 0)
        {
            toMenuUI.SetActive(true);
        }
    }
    public void OnPlayerDeath()
    {
        SceneManager.LoadScene("LvlTutorial");
    }
}
