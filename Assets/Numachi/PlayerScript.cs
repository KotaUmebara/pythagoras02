using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    bool hit = false;
    public GameObject flag;
    float rotSpeed = 1f;
    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        hit = true;
    }

    void Update()
    {
        Debug.Log(flag.transform.rotation.x);

        if (hit == true)
        {
            if(flag.transform.rotation.x < 0)
            {
                rotSpeed = 0;
            }
            flag.transform.Rotate(-rotSpeed, 0, 0);

        }
    }


}
