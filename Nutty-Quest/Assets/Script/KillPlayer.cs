using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public int Respawn;
    // Start is called before the first frame update
    void StartKillPlayer()
    {
        
    }

    // Update is called once per frame
    void UpdateKillPlayer ()
    {
        
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // if (nuddar player)
        {
            SceneManager.LoadScene(Respawn); //starta om scenen
        }
    }
}
