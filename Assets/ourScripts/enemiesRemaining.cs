using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class enemiesRemaining : MonoBehaviour
{

    public static int remainingEnemies = 7;
    Text counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        counter.text = "Enemies Remaining: " + remainingEnemies;
    }
}
