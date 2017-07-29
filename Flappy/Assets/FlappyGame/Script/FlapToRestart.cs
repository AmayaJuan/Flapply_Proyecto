using UnityEngine;
using UnityEngine.SceneManagement;

public class FlapToRestart : MonoBehaviour
{
    public string nivel = "";

	void Update ()
    {
        if (Input.GetMouseButton(0))
            SceneManager.LoadScene(nivel);
    }
}
