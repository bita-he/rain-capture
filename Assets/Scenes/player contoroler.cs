using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody2D _rb;
    float speed = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        speed = 8.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

      public void Movement()
      {
        var xAxis = Input.GetAxisRaw("Horizontal");
      
        var force = new Vector2(xAxis * (speed * Time.deltaTime), 0);
        _rb.AddForce(force, ForceMode2D.Impulse);
      }
}
