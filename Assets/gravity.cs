using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    public float Intensity = 5, Range = 5, MinDepth = 0;
    float MaxDepth;
    
    Collider2D[] Bodies;
    void Start()
    {
        MaxDepth = Range;
    }

    // Update is called once per frame
    void Update()
    {
        ApplyGravity();
    }

    void ApplyGravity()
    {
        Bodies = Physics2D.OverlapCircleAll(transform.position, Range, ~0, MinDepth, MaxDepth);
        foreach(Collider2D b in Bodies)
        {
            Vector2 direction = transform.position - b.gameObject.transform.position;
            float distance = Vector2.Distance(this.transform.position, b.gameObject.transform.position);
            direction.Normalize();
            float DistanceIntensity = (distance / Range) * Intensity;

            Rigidbody2D rb = b.gameObject.GetComponent<Rigidbody2D>();
            rb.AddForce(direction * DistanceIntensity);
        }

    
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, Range);
    }
}
