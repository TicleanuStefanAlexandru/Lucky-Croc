using UnityEngine;
using UnityEngine.UI;

public class DaveUI : MonoBehaviour
{
    public DaveStats daveStats;

    public Text healthText;
    public Text staminaText;
    public Text chipsText;

    void Update()
    {
        if (daveStats == null) return;

        healthText.text = "Health: " + daveStats.health + "/" + daveStats.maxHealth;
        staminaText.text = "Stamina: " + Mathf.FloorToInt(daveStats.stamina) + "/" + daveStats.maxStamina;
        chipsText.text = "Chips: " + daveStats.chips;

    }
}