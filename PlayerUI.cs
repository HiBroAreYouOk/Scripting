using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;
    void Update()
    {
        healthSlider.maxValue = player.playerMaxHealth;
        healthSlider.value = player.playerHealth;
        coinsCounterText.text = player.coins.ToString();
    }
}
