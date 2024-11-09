using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initialvelocitypush : MonoBehaviour
{
    public float Speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * Speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
