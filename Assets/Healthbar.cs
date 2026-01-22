using UnityEngine;

public class Healthbar : MonoBehaviour
{
    [SerializeFeild] private Health playerHealth;
    [SerializeFeild] private Health totalhealthBar;
    [SerializeFeild] private Health currenthealthBar;
    private void Start()
    {
        totalhealthBar.fillAmount = playerHealth.currentHealth / 10;
    }
    private void Update()
    {
        currenthealthBar.fillAmount = playerHealth.currentHealth / 10;
    }
}