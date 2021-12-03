using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textDirection : MonoBehaviour
{
    Vector3 Tpos;
    GameObject tf;
    // Start is called before the first frame update
    void Start()
    {
 
        //InvokeRepeating("getPos", 2.0f, 2.0f);
    }

    void getPos()
    {
        tf = GameObject.FindGameObjectWithTag("target");
        Tpos = GameObject.FindGameObjectWithTag("target").transform.position;
        Vector3 tp = new Vector3(Tpos.x, Tpos.y, Tpos.z);
        transform.position = tp;
    }

    void OnEnable()
    {
        Tpos = GameObject.FindGameObjectWithTag("target").transform.position;
        Vector3 tp = new Vector3(Tpos.x, Tpos.y, Tpos.z);
        transform.position = Tpos;
    }

    void OnDisable()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Tpos = GameObject.FindGameObjectWithTag("target").transform.position;

        if (transform.position.x < (Tpos.x - 0.04))
        {
            transform.position = new Vector3(transform.position.x + 0.005f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > (Tpos.x + 0.01))
        {
            transform.position = new Vector3(transform.position.x - 0.005f, transform.position.y, transform.position.z);
        }

        if (transform.position.y < (Tpos.y - 0.12))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.005f, transform.position.z);
        }
        else if (transform.position.y > (Tpos.y + 0.04))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.005f, transform.position.z);
        }

        transform.LookAt(Camera.main.transform);
        Quaternion q = Camera.main.transform.rotation;
        transform.rotation = Quaternion.Euler(q.eulerAngles.x, q.eulerAngles.y, q.eulerAngles.z + 90);
    }
}
