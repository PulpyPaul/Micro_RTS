using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
    /*
    public GameObject allyBase;
    public GameObject enemyBase;


    GameObject[] gos;
    public static Dictionary<string, GameObject> closeObj = new Dictionary<string, GameObject>();
    GameObject closest;
    float distance;
    Vector3 position;
    GameObject ally;
    GameObject enemy;
    Vector3 diff;
    */
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine("FindCloseUnit");
    }
    /*
    public GameObject FindClosestUnit(string tag)
    {
        gos = GameObject.FindGameObjectsWithTag(tag);
        closest = null;
        distance = Mathf.Infinity;
        if (tag == "unit")
        {
            position = allyBase.transform.position;
        }
        else
        {
            position = enemyBase.transform.position;
        }

        foreach (GameObject go in gos)
        {
            diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }

    IEnumerator FindCloseUnit()
    {
        for (; ; )
        {
            ally = FindClosestUnit("unit");
            enemy = FindClosestUnit("eunit");

            closeObj.Clear();
            closeObj.Add(ally);
            closeObj.Add(enemy);

            yield return new WaitForSeconds(.1f);
        }
    }
    */

}
