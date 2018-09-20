using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMelee : Unit {

	// Use this for initialization
	void Start () {
        speed = -0.1f;
        cost = 10.0f;
        health = 100.0f;
        damage = 20.0f;
        this.transform.Rotate(new Vector3(0, 180, 0));
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (health <= 0.0f)
        {
            this.gameObject.SetActive(false);
        }
        if (speed < 0.0f)
        {
            transform.position += Vector3.right * speed;
        }
        else
        {

        }
    }
    /*
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == this.tag)
        {
            Debug.Log("HI");
            Physics2D.IgnoreCollision(this.gameObject.GetComponent<Collider2D>(), col.gameObject.GetComponent<Collider2D>());
        }
        if (timer > 2.0f)
        {
            
            if (col.gameObject.tag == "unit" || col.gameObject.tag == "base")
            {
                Debug.Log("hit");
                col.gameObject.GetComponent<Unit>().health -= damage;
                speed = 0.0f;
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


        if (other.gameObject.tag == "unit" || other.gameObject.tag == "base")
        {
            speed = 0.0f;

        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "unit" || other.gameObject.tag == "base")
        {
            speed = 0.0f;

        }
        else
        {
            speed = -0.1f;
        }
        if (timer > 1.0f)
        {
            other.gameObject.GetComponent<Unit>().health -= damage;
            timer = 0.0f;

        }
    }
}
