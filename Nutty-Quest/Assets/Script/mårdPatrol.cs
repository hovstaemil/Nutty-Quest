using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mårdPatrol : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    private Rigidbody2D rb;
    private Animator anim;
    private Transform currentPoint;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = pointB.transform; //deklareras som pointB för att åka åt rätt håll i starten
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position; //anvstånd mellan position och point B(current point)
        if (currentPoint == pointB.transform)
        {
            rb.velocity = new Vector2(speed, 0); //hastighet åt höger
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0); //hastighet åt väster
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform) //om nära point B (närmre än 0.5)
        {
            flip();
            currentPoint = pointA.transform; 
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform) //om nära point A (närmre än 0.5)
        {
            flip();
            currentPoint = pointB.transform;
        }
    }

    //flippar spriten på x-axeln
    private void flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;

    }

    //ritar upp pointsen i "editmode" så att man ser dem (cirkeln med korset i och sträcket mellan pointA och pointB)
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pointA.transform.position, 0.3f);
        Gizmos.DrawWireSphere(pointB.transform.position, 0.3f);
        Gizmos.DrawLine(pointA.transform.position, pointB.transform.position);
    }
}
