using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour

{
    public string nextLevel = "Level2";
    private int CoinCounter = 0;
    private int Health = 0;
    public Transform RespawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
        private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    Health--;
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
 
         
