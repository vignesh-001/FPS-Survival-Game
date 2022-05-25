using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    private NavMeshAgent Nav;
    private Animator Anim;
    private Transform TheTarget;
    private float DistanceToTarget;
    private int TargetNumber = 1;
    private bool HasStopped = false;
    [SerializeField] float StopDistance = 2.0f;
    [SerializeField] int MaxTargets = 10;
    [SerializeField] float WaitTime = 2.0f;
    private bool Randomizer = true;
    private int NextTargetNumber; 

    [SerializeField] Transform Target1;     
    [SerializeField] Transform Target2;
    [SerializeField] Transform Target3;
    [SerializeField] Transform Target4;
    [SerializeField] Transform Target5;
    [SerializeField] Transform Target6;
    [SerializeField] Transform Target7;
    [SerializeField] Transform Target8;
    [SerializeField] Transform Target9;
    [SerializeField] Transform Target10;

    void Start()
    {
        Nav = GetComponent<NavMeshAgent>();
        Anim = GetComponent<Animator>();
        TheTarget = Target1;
    }

    void Update()
    {
        DistanceToTarget = Vector3.Distance(TheTarget.position,transform.position);
        
        if(DistanceToTarget > StopDistance)
        {
            Nav.SetDestination(TheTarget.position);
            Nav.isStopped = false; 
            Anim.SetInteger("State",0); 
            NextTargetNumber = TargetNumber;
        }
        
        if(DistanceToTarget < StopDistance)
        {
            Nav.isStopped = true;
            Anim.SetInteger("State",1);
            StartCoroutine(Idle());
        }
            
    }

    void SetTarget()
    {
        if (TargetNumber == 1)
        {
            TheTarget = Target1;
        }
        if (TargetNumber == 2)
        {
            TheTarget = Target2;
        }
        if (TargetNumber == 3)
        {
            TheTarget = Target3;
        }
        if (TargetNumber == 4)
        {
            TheTarget = Target4;
        }
        if (TargetNumber == 5)
        {
            TheTarget = Target5;
        }
        if (TargetNumber == 6)
        {
            TheTarget = Target6;
        }
        if (TargetNumber == 7)
        {
            TheTarget = Target7;
        }
        if (TargetNumber == 8)
        {
            TheTarget = Target8;
        }
        if (TargetNumber == 9)
        {
            TheTarget = Target9;
        }
        if (TargetNumber == 10)
        {
            TheTarget = Target10;
        }
    }
    
    IEnumerator Idle()
    {
        yield return new WaitForSeconds(WaitTime);
        if(HasStopped == false)
        {
            HasStopped = true; 
            if (Randomizer == true)
            {
                Randomizer = false;
                TargetNumber = Random.Range(1, MaxTargets);
            
            if(TargetNumber == NextTargetNumber)            
            {
                TargetNumber++;           
                if (TargetNumber >= MaxTargets)
                {
                    TargetNumber = 1;
                }            
            }
            
            SetTarget();

            yield return new WaitForSeconds(WaitTime);
            HasStopped = false;
            Randomizer = true;
            }
        }
    }
}
