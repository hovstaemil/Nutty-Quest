using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m�rdPatrol : MonoBehaviour
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
        currentPoint = pointB.transform; //deklareras som pointB f�r att �ka �t r�tt h�ll i starten
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position; //anvst�nd mellan position och point B(current point)
        if (currentPoint == pointB.transform)
        {
            rb.velocity = new Vector2(speed, 0); //hastighet �t h�ger
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0); //hastighet �t v�ster
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform) //om n�ra point B (n�rmre �n 0.5)
        {
            flip();
            currentPoint = pointA.transform; 
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform) //om n�ra point A (n�rmre �n 0.5)
        {
            flip();
            currentPoint = pointB.transform;
        }
    }

    //flippar spriten p� x-axeln
    private void flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;

    }

    //ritar upp pointsen i "editmode" s� att man ser dem (cirkeln med korset i och str�cket mellan pointA och pointB)
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pointA.transform.position, 0.3f);
        Gizmos.DrawWireSphere(pointB.transform.position, 0.3f);
        Gizmos.DrawLine(pointA.transform.position, pointB.transform.position);
    }
}
