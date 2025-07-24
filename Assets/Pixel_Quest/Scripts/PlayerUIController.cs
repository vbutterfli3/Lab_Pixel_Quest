using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerUIController : MonoBehaviour
{
    public Image heartImage;

  
    // Start is called before the first frame update
    public void Start()
    {
        heartImage = GameObject.Find("heart1").GetComponent<Image>();
    }

    // Update is called once per frame
    public void UpdateHealth(float currentHealth, float maxHealth)
    {
        heartImage.fillAmount = currentHealth / maxHealth;
    }
}
