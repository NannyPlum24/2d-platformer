using UnityEngine;
using System.Collections;
using UnityEditor.Rendering;

public class Enemy : MonoBehaviour
{
    public Animator animator;

    public int maxHealth = 100;
    public int currentHealth;
    bool IsHurt = false;
    bool IsDead = false;

    float delayTime = 0.1f;
    void Start()
    {
        currentHealth = maxHealth;

    }

    public void TakeDamage(int damage)
    {
       currentHealth -= damage;
       

        StartCoroutine(DelayAction(delayTime));

      

       

    }

    void Die()
    {
        animator.SetBool("IsDead", true);
        Debug.Log("Enemy died!");
       

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;




    }

    IEnumerator DelayAction(float delayTime)
    {
        if (currentHealth <= 0)
        {
            Die();
        } 
        else
        {
            animator.SetBool("IsHurt", true);
            //Wait for the specified delay time before continuing.
            yield return new WaitForSeconds(delayTime);

            //Do the action after the delay time has finished.
            animator.SetBool("IsHurt", false);

        }

          
    }
}
