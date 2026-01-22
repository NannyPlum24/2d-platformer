using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeFeild]private float startingHealth;
    internal float fillAmount;

    public float currentHealth { get; private set; }

    private void Awake()
    {
        currentHealth = startingHealth;
    }
    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
        if (currentHealth > 0)
        {


        }
        else
        {

        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            TakeDamage(1);
        }
    }
}
