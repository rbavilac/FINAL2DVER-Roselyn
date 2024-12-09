using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{

    public Animator animator;
    public Transform attackPoint;
    public float attackingRange = 0.5f;
    public LayerMask enemyLayers;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();

        }
    }

    void Attack()
    {

        //play an attack animation
        animator.SetTrigger("Attack");

        //detect enemies in a range of attack
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackingRange, enemyLayers);
        // damage them
        foreach (Collider2D enemy in hitEnemies)
        {
         enemy.GetComponent<EnemyCAT>().TakeDamage(2); 
         Debug.Log("damage!!!: ");
        }
    }

    void OnDrawGizmos()
     {
        if (attackPoint==null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackingRange);
        
    }

}
