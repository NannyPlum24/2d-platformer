using System.ComponentModel.Design;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int attackDamage = 40;
    bool attack = false;
    
    void Update()
    {
        




        if (Input.GetKeyDown(KeyCode.Q))
        {
            attack = true;
            animator.SetBool("IsAttacking", true); 
           
        }
        else
        {
            attack = false;
            animator.SetBool("IsAttacking", false);
        }

 
        if (attack == true)
        {
            Attack();
        }


        void Attack()
        {
            animator.SetTrigger("Attack");


           Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position,attackRange, enemyLayers );


            foreach(Collider2D enemy in hitEnemies)
            {
                enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
            }
        
        
        
        
        
        }

    
        void OnDrawGizmosSelected()
        {
            if (attackPoint == null)
                return;

            Gizmos.DrawWireSphere(attackPoint.position, attackRange);

        }
    
    
    
    
    
    
    }
}
