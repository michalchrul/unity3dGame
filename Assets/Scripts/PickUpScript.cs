using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    public GameObject boxOfPandora;
    public GameObject box;
    public GameObject particles;
    public GameObject scoreText;
    bool wasTheObjectPicked = false;
    ScoreScript scoreScript;
    public GameManager gameManager;

    float x;
    float y;
    float z;
    Vector3 position;

    void Start()
    {
        box.SetActive(true);
        particles.SetActive(true);
        GetComponent<Animator>().enabled = false;
        GetComponent<AudioSource>().enabled = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup();
        }


    }

    void Pickup()
    {
        
        GetComponent<Animator>().enabled = true;
        box.SetActive(false);
        particles.SetActive(false);
        //Debug.Log("Pick up.");
        if (wasTheObjectPicked == false)
        {
            FindObjectOfType<AudioManager>().Play("PickUp");
            GetComponent<AudioSource>().enabled = false;

            scoreScript = scoreText.GetComponent<ScoreScript>();
            scoreScript.score += 100;
            wasTheObjectPicked = true;

            if(scoreScript.score == 300)
            {
                FindObjectOfType<AudioManager>().Play("pad");
                Invoke("FinishLevel",2f);
            }

            position = CalculatePosition();
            Instantiate(boxOfPandora, position, Quaternion.identity);

        }
    
    }

    Vector3 CalculatePosition()
    {
        x = Random.Range(-106, 111);
        y = 0.3f;
        z = Random.Range(201, 728);
        Vector3 pos = new Vector3(x, y, z);
        return pos;
        //transform.position = pos;
    }

    void FinishLevel()
    {
        gameManager.CompleteLevel();
    }

    

}
