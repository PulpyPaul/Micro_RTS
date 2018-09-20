using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeUnit : Unit {

    // Use this for initialization
    void Start()
    {
        speed = 0.1f;
        cost = 10.0f;
        health = 100.0f;
        damage = 20.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (health <= 0.0f)
        {
            this.gameObject.SetActive(false);
        }
        if (speed > 0.0f)
        {

            transform.position += Vector3.right * speed;
        }
        else
        {

        }
    }
    /*
    void OnCollisionEnter2D(Collision2D other)
    {
        if (timer > 1.0f)
        {
            if (other.gameObject.tag == "eunit" || other.gameObject.tag == "enemybase")
            {
                Debug.Log("hit");
                speed = 0.0f;
                other.gameObject.GetComponent<Unit>().health -= damage;
                timer = 0.0f;

            }
        }
    }
    */
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == this.tag)
        {
            Physics2D.IgnoreCollision(this.gameObject.GetComponent<Collider2D>(), other.gameObject.GetComponent<Collider2D>());
        }


        if (other.gameObject.tag == "eunit" || other.gameObject.tag == "enemybase")
        {
            speed = 0.0f;

        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "eunit" || other.gameObject.tag == "enemybase")
        {
            speed = 0.0f;

        }
        else
        {
            speed = 0.1f;
        }
        if (timer > 1.0f)
        {
            other.gameObject.GetComponent<Unit>().health -= damage;
            timer = 0.0f;

        }
    }
}
