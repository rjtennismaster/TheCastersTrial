using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increaseEnemyDeathCount : MonoBehaviour
{

    public void increaseEnemyCounter()
    {
        GameObject.Find("Ellen").GetComponent<killall>().increaseEnemiesDeadCounter();
        enemiesRemaining.remainingEnemies = 7- GameObject.Find("Ellen").GetComponent<killall>().enemiesDeadCounter;
    }
}
