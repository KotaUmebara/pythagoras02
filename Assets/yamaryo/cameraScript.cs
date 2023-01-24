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
        //�Q�[���J�n���_�̃J�����ƃ{�[���̋������擾
        offset = gameObject.transform.position - target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�{�[�����ړ�������ɃJ�������ړ�����悤�ɂ���
    private void LateUpdate()
    {
        gameObject.transform.position = target.transform.position + offset;
    }
}
