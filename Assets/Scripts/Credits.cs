using UnityEngine;

public class Credits : MonoBehaviour
{
    public void Quit()
    {
        FindObjectOfType<AudioManager>().Play("quitGame");
        Invoke("ActuallyQuit", 1f);
    }

    public void ActuallyQuit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
