using System.Collections;
using System.Collections.Generic;
using Gamekit3D.Message;
using UnityEngine;
using UnityEngine.AI;
#if UNITY_EDITOR
using UnityEditor;
using MessageType = UnityEditor.MessageType;
#endif

public class EvilToadBehavior: MonoBehaviour
{

    public NavMeshAgent agent;

    public Transform player;

    public LayerMask isGround, isPlayer;

    public Vector3 walkingPoint;
    public bool ispointSet;
    public float walkingpointRange;

    public float attacktimeRange;
    bool hasAttacked;

    public float visionRange, attackRange;
    public bool invisionRange, inattackRange;

    void Awake() {
        player = GameObject.Find("PlayerName").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        invisionRange = Physics.CheckSphere(transform.position, visionRange, isPlayer);
        inattackRange = Physics.CheckSphere(transform.position, attackRange, isPlayer);

        if(!invisionRange && !inattackRange) Disengaged();
        if(invisionRange && !inattackRange) SpotPlayer();
        if(invisionRange && inattackRange) AttackPlayer();
    }

    void Disengaged() {

    }

    void SpotPlayer() {

    }

    void AttackPlayer() {


    }
}
