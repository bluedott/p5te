using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //if (topHeaderBoxCollider.bounds.Intersects(currentHeader.boxCollider.bounds))

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OKOOKOKOOK");
        Debug.Log("OKOOKOKOOK");
        Debug.Log("OKOOKOKOOK");
        Debug.Log("OKOOKOKOOK");
        Debug.Log("OKOOKOKOOK");
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Allergens")
        {
            Debug.Log("737747474");
            Debug.Log("OKOOKOKOOK");
            Debug.Log("OKOOKOKOOK");
            Debug.Log("48484848484");
            if (transform.position.x > Screen.height/2)
            {
                /*while (transform.position.x > Screen.height/2 & transform.position.x > 100)
                {
                    transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
                }*/
                //transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y, transform.position.z);
            }
            else
            {
               // transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
            }
   
        }

    }

}
