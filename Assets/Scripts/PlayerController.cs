using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool jump = false;
    public bool slide = false;
    public Animator Animator;
    public GameObject trigger;
    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    { 
        transform.Translate(0,0,0.1f);
        if (Input.GetKey(KeyCode.Space)) 
        { 
            jump = true;
        }
        else
        {
            jump = false;
        }
        if(jump == true) 
        {
            Animator.SetBool("isJump", jump);
            transform.Translate(0, 0.3f, 0.1f);
        }
        else if (jump == false)
            {
                Animator.SetBool("isJump", jump);
            }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            slide = true;
        }
        else
        {
            slide = false;
        }
        if (slide == true)
        {
            Animator.SetBool("isSlide", slide);
            transform.Translate(0, 0, 0.1f);
        }
        else if (slide == false)
        {
            Animator.SetBool("isSlide", slide);
        }
        trigger = GameObject.FindGameObjectWithTag("Obstacle");
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PlayerTrigger")
        {
            Destroy(trigger);
        }
    }
}
