using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static TakeTheNutt;

public class Win : MonoBehaviour
{
    public int Victory;
    // Start is called before the first frame update
    void StartWin()
    {

    }

    // Update is called once per frame
    void UpdateWin()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && HasTheNutt == true) 
        {
            SceneManager.LoadScene("Victory");
        }
    }
}