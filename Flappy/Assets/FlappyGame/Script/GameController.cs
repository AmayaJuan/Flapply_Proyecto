using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public bool gameOver;
    public GameObject gameOverText;
    public Text scoreText;

    int score;

    void Awake()
    {
        if (GameController.instance == null)
            GameController.instance = this;
        else if (GameController.instance != this)
            Destroy(gameObject);
    }

    public void BirdDie()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }

    public void BirdScored()
    {
        if (gameOver) return;
        score++;
        scoreText.text = "Score: " + score.ToString();
        SoundSystem.instance.PlayCoin();
    }

    void OnDestroy()
    {
        if (GameController.instance == this)
            GameController.instance = null;
    }
}
