using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PizzaHealthSystem : MonoBehaviour
{
    public Image[] pizzaSlices; // Assign 4 slices in the Inspector
    private int currentHealth;

    void Start()
    {
        currentHealth = pizzaSlices.Length; // 4 by default
        UpdatePizzaDisplay();
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, pizzaSlices.Length);
        UpdatePizzaDisplay();
    }

    void UpdatePizzaDisplay()
    {
        for (int i = 0; i < pizzaSlices.Length; i++)
        {
            pizzaSlices[i].enabled = i < currentHealth;
        }
    }

    // Optional: test input
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1); // Take 1 damage on Spacebar press
        }
    }
}
