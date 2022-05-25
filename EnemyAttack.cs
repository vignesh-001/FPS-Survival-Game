using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAttack : MonoBehaviour
{
    private NavMeshAgent Nav;
    private NavMeshHit Hit;
    private bool blocked = false;
    private bool RunToPlayer = false;
    private float DistanceToPlayer;
    private bool IsChecking = true;
    private int FailedChecks = 0;                        
    
    [SerializeField] Transform Player;
    [SerializeField] Animator Anim;
    [SerializeField] GameObject Enemy;
    [SerializeField] float MaxRange = 35.0f;
    [SerializeField] int MaxChecks = 3;                 
    [SerializeField] float ChaseSpeed = 8.5f;
    [SerializeField] float WalkSpeed = 1.6f;
    [SerializeField] float AttackDistance = 2.3f;
    [SerializeField] float AttackRotateSpeed = 2.0f;
    [SerializeField] float CheckTime = 3.0f;
   
    void Start()
    {
        Nav = GetComponentInParent<NavMeshAgent>();
    }

    void Update()
    {
        DistanceToPlayer = Vector3.Distance(Player.position,Enemy.transform.position);
        if(DistanceToPlayer < MaxRange)
        {
            if (IsChecking == true)
            {
                IsChecking = false;
                blocked = NavMesh.Raycast(transform.position, Player.position, out Hit, NavMesh.AllAreas);
                if(blocked == false)
                {
                   RunToPlayer = true;         
                   FailedChecks = 0;
                }

                if (blocked == true)
                {
                    RunToPlayer = false;
                    Anim.SetInteger("State",1);
                    FailedChecks++;
                }

                StartCoroutine(TimedCheck());
            }
        }

        if(RunToPlayer == true)
        {
            Enemy.GetComponent<EnemyMove>().enabled = false;
            if (DistanceToPlayer > AttackDistance)
            {
                Nav.isStopped = false;
                Anim.SetInteger("State" , 2);
                Nav.acceleration = 24;
                Nav.SetDestination(Player.position);
                Nav.speed = ChaseSpeed;
            }

            if (DistanceToPlayer < AttackDistance - 0.5f)
            {
                Anim.SetInteger("State",3);
                Nav.acceleration = 180;
                Vector3 Pos = (Player.position - Enemy.transform.position).normalized;
                Quaternion PosRotation = Quaternion.LookRotation(new Vector3(Pos.x, 0 ,Pos.z));
                Enemy.transform.rotation = Quaternion.Slerp(Enemy.transform.rotation, PosRotation, Time.deltaTime * AttackRotateSpeed);
            }
        }
        else if(RunToPlayer == false)
        {
            Nav.isStopped = true; 
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            RunToPlayer = true;
        }

         if (other.gameObject.CompareTag("PKnife"))
        {
            //Anim.SetTrigger("SmallReact");
        }

        if (other.gameObject.CompareTag("PAxe"))
        {
            //Anim.SetTrigger("SmallReact");
        }

        if (other.gameObject.CompareTag("PBat"))
        {
            //Anim.SetTrigger("SmallReact");
        }

        if (other.gameObject.CompareTag("PCrossbow"))
        {
            //Anim.SetTrigger("SmallReact");
        }
    }

    IEnumerator TimedCheck()
    {
        yield return new WaitForSeconds(CheckTime);
        IsChecking = true;

        if(FailedChecks > MaxChecks)
        {
            Enemy.GetComponent<EnemyMove>().enabled = true;
            Nav.isStopped = false;
            Nav.speed = WalkSpeed;
            FailedChecks = 0;
        }
    }

}
