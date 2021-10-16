using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIGoToLvl : MonoBehaviour
{
    public void GoToLevel(string name)
    {
        SceneManager.LoadScene(name);
    }
}
