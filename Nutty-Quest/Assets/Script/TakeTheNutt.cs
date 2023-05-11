using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TakeTheNutt : MonoBehaviour
{
    public static bool HasTheNutt = false;
    // Start is called before the first frame update
    void StartTakeTheNutt()
    {

    }

    // Update is called once per frame
    void UpdateTakeTheNutt()
    {

    }

    void TakeTheNuttt (Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            print("has the nut");
            HasTheNutt = true;
        }
    }
}