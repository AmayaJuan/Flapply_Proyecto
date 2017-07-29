using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject gameOverText;
    public Text scoreText;
    public bool gameOver;
    public float scrollSpeed = -1.5f;

    int score;

    void Awake()
    {
        if (GameController.instance == null)
            GameController.instance = this;
        else if (GameController.instance != this)
            Destroy(gameObject);
    }
	
	void Update ()
    {
        if (gameOver && Input.GetMouseButton(0))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
    }

    void OnDestroy()
    {
        if (GameController.instance == this)
            GameController.instance = null;
    }
}
