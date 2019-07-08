﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{

    [Range(0f, 5f)] [SerializeField] float walkSpeed = 1f;
    GameObject currentTarget;
    Animator animator;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
        UpdateAnimation();


    }

    private void UpdateAnimation()
    {
        if (!currentTarget)
        {
            GetComponent<Animator>().SetBool("IsAttacking", false);
        }
    }

    public void setWalkSpeed(float walkSpeed)
    {
        this.walkSpeed = walkSpeed;
    }

    public void Attack (GameObject target)
    {
        GetComponent<Animator>().SetBool("IsAttacking", true);
        currentTarget = target;

    }

    public void StrikeCurrentTarget(float damage)
    {
        if (!currentTarget) { return; }
        Health health= currentTarget.GetComponent<Health>();
        if (health)
        {
            health.DealDamage(damage);
        }
        
    }
}
