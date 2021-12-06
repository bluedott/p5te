using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textDirection : MonoBehaviour
{
    Vector3 targetPos;
    GameObject target;
    Vector3 objectPos;
    Vector3 targetSize;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("target");
    }

    void OnEnable()
    {
        targetPos = target.transform.position;
        transform.position = targetPos;
    }

    // Update is called once per frame
    void Update()
    {
        targetSize = target.GetComponent<Collider>().bounds.size;
        objectPos = transform.position;
        targetPos = target.transform.position;

        //X position
        if (objectPos.x < (targetPos.x - targetSize.x/2))
        {
            transform.position = new Vector3(objectPos.x + 0.005f, objectPos.y, objectPos.z);
            Debug.Log("Down");
        }
        else if (objectPos.x > (targetPos.x + targetSize.x/2))
        {
            transform.position = new Vector3(objectPos.x - 0.005f, objectPos.y, objectPos.z);
            Debug.Log("Up");
        }

        //Y position
        if (objectPos.y < (targetPos.y - targetSize.y/2))
        {
            transform.position = new Vector3(objectPos.x, objectPos.y + 0.005f, objectPos.z);
            Debug.Log("Right");
        }
        else if (objectPos.y > (targetPos.y + targetSize.y/2))
        {
            transform.position = new Vector3(objectPos.x, objectPos.y - 0.005f, objectPos.z);
                Debug.Log("Left");
        }

        //Z position
        if (objectPos.z < (targetPos.z - targetSize.z/2))
        {
            transform.position = new Vector3(objectPos.x, objectPos.y , objectPos.z + 0.005f);
        }
        else if (objectPos.z > (targetPos.z + targetSize.z/2))
        {
            transform.position = new Vector3(objectPos.x, objectPos.y , objectPos.z - 0.005f);
        }

        //Look and rotate towards camera
        transform.LookAt(Camera.main.transform);
        Quaternion q = Camera.main.transform.rotation;
        transform.rotation = Quaternion.Euler(q.eulerAngles.x, q.eulerAngles.y, q.eulerAngles.z + 90);
    }
}
