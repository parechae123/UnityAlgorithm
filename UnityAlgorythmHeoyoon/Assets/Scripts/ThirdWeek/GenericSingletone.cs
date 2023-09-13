using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericSingletone<T> : MonoBehaviour where T : Component
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<T>();
                if (_instance == null)
                {
                    GameObject obj = new GameObject();  //��ü �����
                    obj.name = typeof(T).Name;          //������Ʈ �̸� ����
                    _instance = obj.AddComponent<T>();  //�ν��Ͻ� ���۳�Ʈ�� ���δ�.
                }
            }
            return _instance;
        }
    }
    public virtual void Awake()                                //Awake�� ����ɶ�
    {
        Debug.Log("��Ʈ���� ���� ��");
        if (_instance == null)                           //�ش� �ν��Ͻ��� �������� ������
        {
            _instance = this as T;                            //�ν��Ͻ��� �� Ŭ���� -> class Singleton
            DontDestroyOnLoad(gameObject);              //����Ƽ�� �ı����� �ʴ� ��ü�� ���
            Debug.Log("��Ʈ���� ����");
        }
        else if (_instance != this)
        {
            Debug.Log("��Ʈ���� ���� �ȵ�");
            Destroy(gameObject);                                //�ش� �ν��Ͻ��� �����ϸ� �������ڸ��� �ı��ȴ�.
        }
    }
}
