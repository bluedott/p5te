using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubePos : MonoBehaviour
{
    GameObject tf;
    Vector3 tfPos;
    // Start is called before the first frame update
    void Start()
    {
        tf = GameObject.FindGameObjectWithTag("target");
    }

    // Update is called once per frame
    void Update()
    {
        //var tfPos = Camera.main.ScreenToWorldPoint(tf.transform.position);
        tfPos = tf.transform.position;
        transform.position = new Vector3(tfPos.x + 0.01f, tfPos.y, 0.1f);
        //transform.position = tfPos;
        Debug.Log(tfPos);
        Debug.Log(transform.position);
    }
}
