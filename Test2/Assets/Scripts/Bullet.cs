using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 50;
    public Rigidbody2D rb;
    public GameObject impatEffect;
   
    //void Start()
    void FixedUpdate()
    {
        rb.velocity = transform.right * Time.deltaTime * speed ;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if(enemy != null)
        {
            enemy.TakeDamage(damage);                
        }
       
        Debug.Log("��������� � " + hitInfo.name);
        Instantiate(impatEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
