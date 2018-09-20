using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float dmg;
    public float speed;

    // Use this for initialization
    void Start () {
        dmg = 50.0f;
        if(this.tag == "unit")
        {
            speed = 0.1f;
        }
        else
        {
            speed = -0.1f;
        }

	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.right * speed;
    }
    /*
    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log(col.gameObject.tag);

        if (col.gameObject.tag == "enemybase")
        {
            //this.gameObject.SetActive(false);
        }
        if (col.gameObject.tag == "eunit")
        {
            col.gameObject.GetComponent<Unit>().health -= dmg;
            this.gameObject.SetActive(false);
            //this.gameObject.SetActive(false);
            //col.gameObject.SetActive(false);
        }

    }
    */
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == this.gameObject.tag)
        {
            //this.gameObject.SetActive(false);
            Physics2D.IgnoreCollision(this.gameObject.GetComponent<Collider2D>(), other.gameObject.GetComponent<Collider2D>());
        }
        else
        {
            other.gameObject.GetComponent<Unit>().health -= dmg;
            this.gameObject.SetActive(false);
            //this.gameObject.SetActive(false);
            //col.gameObject.SetActive(false);
        }
    }

}
