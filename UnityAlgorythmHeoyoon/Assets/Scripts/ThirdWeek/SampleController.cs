using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Singletone.Instance.inscreaseScore(10);
        GameManager.Instance.inscreaseScore(15);
        //Start�Լ��� ȣ��ɶ� Instance�� �����ؼ� 10���� �߰�
    }
}
