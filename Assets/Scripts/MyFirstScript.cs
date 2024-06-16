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
                OrderCoffee("Капучино");
                break;
            case 2:
                OrderCoffee("Латте");
                break;
            case 3:
                OrderCoffee("Американо");
                break;
            case 4:
                OrderCoffee("Какао");
                break;
            case 5:
                OrderCoffee("Горячий шоколад");
                break;
            case 6:
                OrderCoffee("Чай с лимоном");
                break;
            case 7:
                OrderCoffee("Горячая вода");
                break;
        }

    }


}
