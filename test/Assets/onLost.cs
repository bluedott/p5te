using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onLost : MonoBehaviour
{
    public GameObject G1;
    void OnTrackingFound()
    {
        G1 = GameObject.Find("Toffifee");
        G1.SetActive(true);
        Debug.Log("OKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK");
        Debug.Log("OK");
        Debug.Log("OK");
        Debug.Log("OK");
        Debug.Log("OK");
    }
}
