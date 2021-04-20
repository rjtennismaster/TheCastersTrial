using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dazeEnemies : MonoBehaviour
{

    Animator animator;
    Animator animator1;
    Animator animator2;
    Animator animator3;
    Animator animator4;
    Animator animator5;
    Animator animator6;
    Animator animator7;

    // Start is called before the first frame update
    void Start()
    {
        animator = GameObject.Find("Chomper").GetComponent<Animator>();
        animator1 = GameObject.Find("Chomper (1)").GetComponent<Animator>();
        animator2 = GameObject.Find("Chomper (2)").GetComponent<Animator>();
        animator3 = GameObject.Find("Chomper (3)").GetComponent<Animator>();
        animator4 = GameObject.Find("Chomper (4)").GetComponent<Animator>();
        animator5 = GameObject.Find("Chomper (5)").GetComponent<Animator>();
        animator6 = GameObject.Find("Chomper (6)").GetComponent<Animator>();
        animator7 = GameObject.Find("Chomper (7)").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Daze"))
        {
            animator.SetBool("Daze", true);
            animator1.SetBool("Daze", true);
            animator2.SetBool("Daze", true);
            animator3.SetBool("Daze", true);
            animator4.SetBool("Daze", true);
            animator5.SetBool("Daze", true);
            animator6.SetBool("Daze", true);
            animator7.SetBool("Daze", true);
        }
    }
}
