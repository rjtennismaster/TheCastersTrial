using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dazeEnemies : MonoBehaviour
{


    List<Animator> animatorList = new List<Animator>();

    // Start is called before the first frame update
    void Start()
    {
        animatorList.Add(GameObject.Find("Chomper").GetComponent<Animator>());
        for(int i = 1; i < 8; i++)
        {
            animatorList.Add(GameObject.Find("Chomper (" + i +")").GetComponent<Animator>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Daze"))
        {
            foreach(Animator animator in animatorList)
            {
                if(animator != null)
                {
                    animator.SetBool("Daze", true);
                }
            }
        }
    }
}
