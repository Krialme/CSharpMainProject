using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Myfirstscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int drink = 4;

        void OrderCoffee(string menu)
        {
          Debug.Log(menu);
        }

        switch (drink)
        {
            case 1:
                OrderCoffee("��������");
                break;
            case 2:
                OrderCoffee("�����");
                break;
            case 3:
                OrderCoffee("���������");
                break;
            case 4:
                OrderCoffee("�����");
                break;
            case 5:
                OrderCoffee("������� �������");
                break;
            case 6:
                OrderCoffee("��� � �������");
                break;
            case 7:
                OrderCoffee("������� ����");
                break;
        }

    }


}
