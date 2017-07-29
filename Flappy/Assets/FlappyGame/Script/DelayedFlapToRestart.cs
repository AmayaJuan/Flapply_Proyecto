using UnityEngine;

public class DelayedFlapToRestart : MonoBehaviour
{
    public GameObject flapToRestart;

    int delay = 1;

    void OnEnable()
    {
        Invoke("EnableFlapToRestart", delay);
    }

    void EnableFlapToRestart()
    {
        flapToRestart.SetActive(true);
    }
}
