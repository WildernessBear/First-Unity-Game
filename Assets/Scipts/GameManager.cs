using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameover = false;

    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
       completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (!gameover)
        {
            gameover = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
