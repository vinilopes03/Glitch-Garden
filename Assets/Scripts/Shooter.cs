using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour{

    [SerializeField] GameObject projectile, gun;
    AttackerSpawnner myLaneSpawner;
    Animator animator;

    private void Start()
    {
        SetLaneSpawner();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (IsAttackerInLane())
        {
          
            animator.SetBool("IsAttacking", true);
        }
        else
        {

            animator.SetBool("IsAttacking", false);
        }
        
    }
    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, Quaternion.identity);
    }

    private bool IsAttackerInLane()
    {
        if (myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private void SetLaneSpawner()
    {
        AttackerSpawnner[] attackers = FindObjectsOfType<AttackerSpawnner>();

        foreach (AttackerSpawnner spawner in attackers)
        {
            bool isClose = (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);
            if (isClose)
            {
                myLaneSpawner = spawner;
            }
        }
    }
}
