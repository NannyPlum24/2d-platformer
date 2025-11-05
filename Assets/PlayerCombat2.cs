using System.ComponentModel.Design;
using UnityEngine;

public class PlayerCombat2 : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int attackDamage = 40;
    bool attack2 = false;

    void Update()
    {





        if (Input.GetKeyDown(KeyCode.E))
        {
            attack2 = true;
            animator.SetBool("IsAttacking2", true);
        }
        else
        {
            attack2 = false;
            animator.SetBool("IsAttacking2", false);
        }
        if (attack2 == true)
        {
            Player_Attack2();
        }



        void Player_Attack2()
        {
            animator.SetTrigger("Attack");
            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);


            foreach (Collider2D enemy in hitEnemies)
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
