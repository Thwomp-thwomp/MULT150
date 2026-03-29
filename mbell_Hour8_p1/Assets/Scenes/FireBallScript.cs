using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    // Default: subtract fixed 5 damage from a default plajer health of 100
    int TakeDamageFromFireball()
    {
        int playerHealth = 100;
        return playerHealth - 5;
    }

    // Subtract given damage from default player health of 100
    int TakeDamageFromFireball(int damage)
    {
        int playerHealth = 100;
        return playerHealth - damage;
    }

    // Subtract given damage from given playerHealth
    int TakeDamageFromFireball(int damage, int playerHealth)
    {
        return playerHealth - damage;
    }




    // Start is called before the first frame update
    void Start()
    {
        int x = TakeDamageFromFireball();
        Debug.Log("player health: " + x);

        int y = TakeDamageFromFireball(25);
        Debug.Log("player health: " + y);

        int z = TakeDamageFromFireball(30, 50);
        Debug.Log("player health: " + z);

    }
}