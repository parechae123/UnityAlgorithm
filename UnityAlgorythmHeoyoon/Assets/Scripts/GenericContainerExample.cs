using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericContainerExample : MonoBehaviour
{
    private GenericContainer<int> intContainer;             //int �����̳�
    private GenericContainer<string> stringContainer;       //string �����̳�
    private void Start()
    {
        intContainer = new GenericContainer<int>(5);            //5ĭ �ʱ�ȭ
        stringContainer = new GenericContainer<string>(5);      //5ĭ �ʱ�ȭ
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))       //Ű����1
        {
            intContainer.Add(Random.Range(1, 100));     //�����̳ʿ� ���Ѵ�
            DisPlayContainerItems(intContainer);        //����׿� ������
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))       //Ű����2
        {
            string randomString = "Item " + Random.Range(1, 10);
            stringContainer.Add(randomString);          //�����̳ʿ� ���Ѵ�
            DisPlayContainerItems(stringContainer);     //����׿� ������
        }
    }
    private void DisPlayContainerItems<T>(GenericContainer<T> container)
    {
        T[] items = container.GetItems();
        string temp = "";

        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] != null)
            {
                temp += items[i].ToString() + " - ";
            }
            else
            {
                temp += "Empty - ";
            }
        }
        Debug.Log(temp);
    }
}

