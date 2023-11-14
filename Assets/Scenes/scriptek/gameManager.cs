using UnityEngine;
using UnityEngine.SceneManagement;

class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverObject;

    private void Start()
    {
        gameOverObject.SetActive(false);
    }

    public void OnGameEnded()
    {
        // GAME OVER SCREEN ON
        gameOverObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("myfirstimeû");
    }
}
