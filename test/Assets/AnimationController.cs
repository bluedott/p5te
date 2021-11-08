using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Update());

    }

    // Update is called once per frame
    IEnumerator Update()
    {
        for (int i  = 0; i<Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("None"))
            {
                anim.Play("OpenBox");
            }
        else if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("OpenBox"))
            {
                yield return new WaitForSeconds(3);
                anim.Play("CloseBox");
            }
        }
            
    }
}
