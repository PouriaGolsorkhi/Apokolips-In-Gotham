using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quitToMainMenu : MonoBehaviour
{
    public void getMeToMainMenu()
    {
        SceneManager.LoadScene(0);

    }
}
