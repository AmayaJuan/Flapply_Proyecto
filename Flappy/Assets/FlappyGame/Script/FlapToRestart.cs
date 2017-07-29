using UnityEngine;
using UnityEngine.SceneManagement;

public class FlapToRestart : MonoBehaviour
{
	void Update ()
    {
        if (Input.GetMouseButton(0))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
