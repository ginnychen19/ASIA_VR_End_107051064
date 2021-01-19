using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    
    public void RestartGame()
    {
        SceneManager.LoadScene("S1");
    }

    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void QuitGame()
    {
       
        Application.Quit();
    }
}