using UnityEngine;

public class CoinScrips : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CharacterController2D.Coins += 1;
        Destroy(gameObject);
        
    }
}
