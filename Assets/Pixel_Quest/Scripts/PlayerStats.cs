using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour

{
   // public string nextLevel = "Level2";
    private int CoinCounter = 0;
    public int Health = 3;
    public Transform RespawnPoint;
    public int maxHealth = 3;
    private PlayerUIController playerUIcontroller;

    // Start is called before the first frame update
    void Start()
    {
        playerUIcontroller = GetComponent<PlayerUIController>();
        playerUIcontroller.UpdateHealth(Health, maxHealth);
    }

    // Update is called once per frame
   
        private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    Health--;
                    playerUIcontroller.UpdateHealth(Health, maxHealth);
                    if (Health <= 0)
                    {  
                        string thislevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thislevel);
                    }
                    else { transform.position = RespawnPoint.position; }
                    break;
                }

            case "Finish":
                {
                    string nextLevel = collision.transform.GetComponent<LevelGoal>().nextLevel;
                    SceneManager.LoadScene(nextLevel);
                    break;
                }

            case "Coin":
                {
                    CoinCounter++;
                    Destroy(collision.gameObject);
                    break;
                }

            case "Health":
                {
                    if (Health < 3)
                    {
                        playerUIcontroller.UpdateHealth(Health, maxHealth);
                        Health++;
                        Destroy(collision.gameObject);
                    }
                    break;
                }
            case "Respawn":
                {
                    RespawnPoint.position = collision.transform.Find("Point").position;
                    break;
                }

        }

    }
}
 
         
