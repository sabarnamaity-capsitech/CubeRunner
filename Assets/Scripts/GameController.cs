using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject tapToStart;
    public GameObject scoretext;
    private void Start()
    {
        gameOverPanel.SetActive(false);
       tapToStart.SetActive(true);
       scoretext.SetActive(false);
        PauseGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartGame();
        }
    }
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        scoretext.SetActive(false);
    }
    public void Restart()
    {
        SceneManager.LoadScene("GameScene");
    }
     public void QuitGame()
    {
       Application.Quit();
    }
    public void PauseGame()
    {
        Time.timeScale=0f;
    }
    public void StartGame()
    {

        Time.timeScale=1f;
       tapToStart.SetActive(false);
       scoretext.SetActive(true);
    }
}
