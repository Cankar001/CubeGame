using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
    {
    bool gameOver = false;
    bool lastLevel = false;

    public float restartDelay = 2f;
    public GameObject completeLevelUI;
    public Text levelIdentity;

    public void levelComplete()
        {
        levelIdentity.gameObject.SetActive(false);
        completeLevelUI.SetActive(true);
        }

    void Update()
        {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        levelIdentity.text = "Level " + currentLevel;

        if (SceneManager.GetActiveScene().buildIndex == 4)
            {
            lastLevel = true;
            }
        else
            {
            lastLevel = false;
            }
        }

    public void GameOver()
        {
        if (!gameOver)
            {
            // Spiel beenden
            gameOver = true;

            // Spiel neu starten
            Invoke("RestartGame", restartDelay);
            }
        }

    void RestartGame()
       {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       }

    public bool isLastLevel()
        {
        return lastLevel;
        }
    }
