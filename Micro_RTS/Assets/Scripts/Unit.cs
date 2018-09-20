using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

	public float speed;
    public float cost;
    public float health;
    public float damage;
    public float timer = 0.0f;

    public Unit()
    {
        speed = 0.1f;
        cost = 10.0f;
        health = 100.0f;
        damage = 20.0f;
    }

    void Start()
    {
        speed = 0.1f;
        cost = 10.0f;
        health = 100.0f;
        damage = 20.0f;
    }

    // Update is called once per frame
    void Update () {
	}
}
