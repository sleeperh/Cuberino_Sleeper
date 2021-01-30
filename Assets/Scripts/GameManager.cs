
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text gameText;
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public string sceneName;



    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            //Debug.Log("Game Over");
            Invoke("Restart", restartDelay); // calls Restart method and 2nd parameter creates a delay
        }
    }
    private void Update()
    {
        if (gameHasEnded == true)
        {
            gameText.text = "FAILED!";
        }
    }
    void Restart()
    {
        completeLevelUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
