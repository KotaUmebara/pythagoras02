using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    [SerializeField]

    private GameObject target;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //ゲーム開始時点のカメラとボールの距離を取得
        offset = gameObject.transform.position - target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //ボールが移動した後にカメラが移動するようにする
    private void LateUpdate()
    {
        gameObject.transform.position = target.transform.position + offset;
    }
}
