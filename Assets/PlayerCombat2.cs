using System.ComponentModel.Design;
using UnityEngine;

public class PlayerCombat2 : MonoBehaviour
{
    public Animator animator;
    // Update is called once per frame
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

        {
            Player_Attack2();
        }



        void Player_Attack2()
        {
            animator.SetTrigger("Player_Attack2");


        }
    }
}
