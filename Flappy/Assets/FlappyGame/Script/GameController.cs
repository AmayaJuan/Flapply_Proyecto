using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject gameOverText;
    public bool gameOver;

    void Awake()
    {
        if (GameController.instance == null)
            GameController.instance = this;
        else if (GameController.instance != this)
            Destroy(gameObject);
    }

    void Start ()
    {
		
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

    void OnDestroy()
    {
        if (GameController.instance == this)
            GameController.instance = null;
        
    }
}
