using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateBottle : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                if (raycastHit.collider.name == "fiskeolie")
                {
                    anim.SetTrigger("fishCollide");
                }

            }
        }
    }

}
