using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 dir;
    private Player player;

    public float speed;
    private Vector2 initialPos;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = dir * speed;
        initialPos = this.transform.position;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(rb.velocity.magnitude);
        if (Vector2.Distance(initialPos, this.transform.position) >= player.range)
            Destroy(this.gameObject);
    }

    public void SetDirection(Vector2 dir)
    {
        this.dir = dir;
    }
}
