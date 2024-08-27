using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    bool gameHasEnded = false;
    public void endgame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("game over");
            Invoke("Restart", 1f);

        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //public void LevelComplete()
    //{
    //    MyCoroutine();
    //}
    //IEnumerator MyCoroutine()
    //{

    //    yield return new WaitForSeconds(2f);
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    //}
    public void LevelComplete()
    {
        StartCoroutine(LoadNextSceneAsync());
    }

    IEnumerator LoadNextSceneAsync()
    {
        yield return new WaitForSeconds(5f);
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(nextSceneIndex);
            while (!asyncLoad.isDone)
            {
                // You can show a loading screen or progress bar here if needed
                yield return null;
            }
        }
        else
        {
            Debug.LogWarning("No more scenes to load!");
        }
    }


}
