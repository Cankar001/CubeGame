using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
    {
    public GameManager gameManager;
    bool isLastLevel = false;

    public void LoadNextLevel()
        {
        isLastLevel = gameManager.isLastLevel();

        if (isLastLevel)
            {
            SceneManager.LoadScene(0);
            }
        else
            {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
