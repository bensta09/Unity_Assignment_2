using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelComplete : MonoBehaviour
{
    void Update()
    {

    }





    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LoadMiniGame()
    {
        SceneManager.LoadScene("MiniGame");
  
    }

    public void LoadNextLevel() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
