using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textDirection : MonoBehaviour
{
    Vector3 Tpos;
    GameObject tf;
    Vector3 tp;
    Vector3 size;
    // Start is called before the first frame update
    void Start()
    {

        //InvokeRepeating("getPos", 2.0f, 2.0f);
        tf = GameObject.FindGameObjectWithTag("target");
        size = tf.GetComponent<Collider>().bounds.size;
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
        size = tf.GetComponent<Collider>().bounds.size;
        tp = transform.position;
        Tpos = GameObject.FindGameObjectWithTag("target").transform.position;
        Debug.Log(size);
        Debug.Log(tp);
        if (tp.x < (Tpos.x - size.x/2))
        {
            transform.position = new Vector3(tp.x + 0.005f, tp.y, tp.z);
        }
        else if (tp.x > (Tpos.x + size.x / 2))
        {
            transform.position = new Vector3(tp.x - 0.005f, tp.y, tp.z);
        }


        if (tp.y < (Tpos.y - size.y / 2))
        {
            transform.position = new Vector3(tp.x, tp.y + 0.005f, tp.z);
        }
        else if (tp.y > (Tpos.y + size.y / 2))
        {
            transform.position = new Vector3(tp.x, tp.y - 0.005f, tp.z);
        }

        transform.LookAt(Camera.main.transform);
        Quaternion q = Camera.main.transform.rotation;
        transform.rotation = Quaternion.Euler(q.eulerAngles.x, q.eulerAngles.y, q.eulerAngles.z + 0);
    }
}
