using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TakeTheNutt : MonoBehaviour
{
    public GameObject N�t;
    public static bool HasTheNutt = false;
    // Start is called before the first frame update
    void StartTakeTheNutt()
    {

    }

    // Update is called once per frame
    void UpdateTakeTheNutt()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) //n�ten nuddar spelare
        {
            print("has the nut");
            HasTheNutt = true;
            N�t.transform.position = new Vector3(1000.0f, 1.0f, 1.0f); //tar bort(flyttar bort) n�ten
        }
    }
}