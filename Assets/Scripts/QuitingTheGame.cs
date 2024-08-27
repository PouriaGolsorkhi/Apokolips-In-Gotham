using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitingTheGame : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("You quited the game!");
        Application.Quit();
    }
}
