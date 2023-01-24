using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UBoxMove : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Box;
    public GameObject Open;
    public Rigidbody RD;
    bool move;
    bool Sove;
    void Start()
    {
        Box = GameObject.Find("MBOX");
        Open = GameObject.Find("Open");
        RD=this.Box.GetComponent<Rigidbody>();
        move = false;
        Sove = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (move == true && Sove == false)
        {
            this.Box.transform.position += new Vector3(0.001f, 0.01f, 0);
        }
        if (this.Box.transform.position.y > 13)
        {
            Sove = true;
        }
        if (this.Box.transform.position.y >= 13)
        {
            Destroy(Open);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        move = true;
    }
}
