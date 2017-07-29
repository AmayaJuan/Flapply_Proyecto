using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public bool game;
    public bool gameOver;
    public GameObject gameOverText;
    public GameObject PlayGame;
    public GameObject Score;
    public Text scoreText;
    public float scrollSpeed = -1.5f;

    int score;

    void Awake()
    {
        if (GameController.instance == null)
            GameController.instance = this;
        else if (GameController.instance != this)
            Destroy(gameObject);
    }

    void Update()
    {
        if(!game && Input.GetMouseButton(0))
        {
            PlayGame.SetActive(false);
            Score.SetActive(true);
            game = true;
        }
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
