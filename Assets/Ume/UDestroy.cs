using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UDestroy : MonoBehaviour
{
    public GameObject Inter;
    void Start()
    {
        Inter = GameObject.Find("Inter");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
            Destroy(Inter);
    }
}
