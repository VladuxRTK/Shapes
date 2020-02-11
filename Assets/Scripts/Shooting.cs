    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public float forceRatio;
    public GameObject bulletPrefab;

    private AudioManager myAudio;

    // Start is called before the first frame update
    void Start()
    {
        myAudio = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - this.transform.position;
            direction = direction.normalized;
            //direction.Normalize();
            GameObject bullet = Instantiate(bulletPrefab, this.transform.position, Quaternion.identity) as GameObject;
            myAudio.PlayAudio("laserAttack");
            //Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            Projectile proj =bullet.GetComponent<Projectile>();
            proj.SetDirection(direction);
           // rb.velocity = direction * forceRatio;
            // rb.AddForce(direction * forceRatio); cu asta mere,dar e cam ciudat
           // Debug.Log(rb.velocity.magnitude);
        }
    }
}
