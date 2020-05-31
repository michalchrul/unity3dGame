using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Animator ani;

    void Start()
    {
       // ani.enabled = false;
    }

    public void StartGame()
    {
        FindObjectOfType<AudioManager>().Play("quitGame");
        // ani.enabled = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
}
