using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public bool IsGameOver { get; private set; }

    public void GameOver()
    {
        IsGameOver = true;
        SceneManager.LoadScene("GameOver");
    }
}
