using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Animator anim;

    public float forwardForce = 2000f;
    public float sidewaysForce = 2000f;

    public bool isAPressed = false;
    public bool isDPressed = false;
    public bool isWPressed = false;

    // Start is called before the first frame update
    void Start()
    {
      FindObjectOfType<AudioManager>().Pause("Footsteps");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // //add a forward force
        // //rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        // if(isWPressed)
        // {
        //     anim.SetFloat("vertical", forwardForce * Time.deltaTime);
        // }
        // if(!isWPressed)
        // {
        //     anim.SetFloat("vertical",0f);
        // }
        
        // if (isAPressed)
        // {
        //    // rb.AddForce(-sidewaysForce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        //     //anim.SetFloat("horizontal", -sidewaysForce* Time.deltaTime);
        //     anim.SetFloat("horizontal", Input.GetAxis("Horizontal"));
        // }
        // if (!isAPressed)
        // {
        //     anim.SetFloat("horizontal", 0f);
        // }

        // if (isDPressed)
        // {
        //   //  rb.AddForce(sidewaysForce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        //     //anim.SetFloat("horizontal", sidewaysForce* Time.deltaTime);
        //     //anim.SetFloat("horizontal", 1);
        //     anim.SetFloat("horizontal", Input.GetAxis("Horizontal"));
        // }
        // if (!isDPressed)
        // {
        //     anim.SetFloat("horizontal", 0f);
        // }
         anim.SetFloat("vertical", Input.GetAxis("Vertical"));
         anim.SetFloat("horizontal", Input.GetAxis("Horizontal"));
    }

    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
           isWPressed = true;
            FindObjectOfType<AudioManager>().Play("Footsteps");
        }

        if (Input.GetKeyUp("w"))
        {
           isWPressed = false;
           FindObjectOfType<AudioManager>().Pause("Footsteps");
        }

        if (Input.GetKeyDown("a"))
        {
           isAPressed = true;
        }

        if (Input.GetKeyUp("a"))
        {
           isAPressed = false;
        }

        if (Input.GetKeyDown("d"))
        {
           isDPressed = true;
        }

        if (Input.GetKeyUp("d"))
        {
           isDPressed = false;
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
