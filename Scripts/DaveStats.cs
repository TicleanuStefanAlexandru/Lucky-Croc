using UnityEngine;

public class DaveStats : MonoBehaviour
{
    [Header("Core Stats")]
    public float speed = 20f;
    public float strength = 10f;
    public float luck = 3f;
    public int health = 100;
    public int maxHealth = 100;
    public int chips = 100;

    [Header("Stamina")]
    public float stamina = 100f;
    public float maxStamina = 100f;
    public float staminaRegenRate = 10f;   // per second
    public float staminaDrainPerSecond = 25f;
    public bool isSprinting = false;

    void Update()
    {
        if (!isSprinting && stamina < maxStamina)
        {
            stamina += staminaRegenRate * Time.deltaTime;
            stamina = Mathf.Min(stamina, maxStamina);
        }
    }

    public void AddChips(int amount)
    {
        chips += amount;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            health = 0;
            Debug.Log("Dave is down!");

        }
    }

    public void Heal(int amount)
    {
        health = Mathf.Min(health + amount, maxHealth);
    }
}
