using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
   public Transform DefaultAvatar;
   public Text scoreText;
   public int score = 0;

    // Update is called once per frame
    void Update()
    {
       // scoreText.text = (DefaultAvatar.position.z -302).ToString("0");
        scoreText.text = (score).ToString("0");

    }
}
