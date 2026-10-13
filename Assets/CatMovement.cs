using UnityEngine;
using System.Collections;
using System.Collections.Generic;




public class CatMovement : MonoBehaviour
{
    public float speed = 3f;
    public float jump = 8f;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float x = 0;

        if (Input.GetKey(KeyCode.A)) x = -1;
        if (Input.GetKey(KeyCode.D)) x = 1;

        rb.linearVelocity = new Vector2(x * speed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jump);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
{
    if (other.gameObject.name == "Misc_38")
    {
        Debug.Log("通關成功！");
        Destroy(other.gameObject);
    }
}
}