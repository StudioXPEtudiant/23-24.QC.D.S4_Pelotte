using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    private Controller controlle;

    public HealthBar healthbar;

    void Start()
    {
       currentHealth = maxHealth;
       healthbar. SetMaxHealth(maxHealth);
       controlle = GetComponent<Controller>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(20);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);

        if(currentHealth <= 0)
        {
            Die();
            return;
        }
    }

      public void Die()
    {
        Debug.Log("nn");
        GameOverManager.instance.OnPlayerDeath();
        controlle.enabled = false;
    }

    public void Revive()
    {
        controlle.enabled = true;
        currentHealth = maxHealth;
    }
}
 