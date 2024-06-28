using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Myfirstscript : MonoBehaviour
{
    enum PlayerState
    {
        Idle = 5,
        Running,
        Jumping = 100000,
        Attacking = 99999
    }

    // Start is called before the first frame update
    void Start()
    {
        float[] floats = {-3, -1, 0, 1.3f, 6, 3, 10, 4, 2, 5, -2 };
        float max = float.MinValue;

        foreach (float f in floats) 
        {
            if(f > max) max = f;
        }
        Debug.Log(max);

    }

    //List<int> inst = new List<int> {0,1,2,3,4,5};
    // List<int> inst1 = inst.ToList();
    // inst1.Add(6);

    //foreach (int i in inst)
    //{
    //    Debug.Log(i);
    //}
    //int jumpingValue = (int) PlayerState.Jumping;

    //PlayerState currentState = PlayerState.Idle;
    //bool isJumping = currentState == PlayerState.Jumping;
    //Debug.Log(isJumping);
    //PrinCurrentState(PlayerState.Idle);
    //PrinCurrentState(PlayerState.Attacking);
    //PrinCurrentState(PlayerState.Jumping);
    //void PrinCurrentState(PlayerState state)
    //{
    //    switch (state)
    //    {
    //        case PlayerState.Idle:
    //            Debug.Log("Now player is idle");
    //            break;
    //        case PlayerState.Running:
    //            Debug.Log("Now player is running");
    //            break;
    //        case PlayerState.Jumping:
    //            Debug.Log("Now player is jumping");
    //            break;
    //        case PlayerState.Attacking:
    //            Debug.Log("Now player is attacking");
    //            break;
    //    }
    //}
    //string[,] schedule = new string[7, 24];

    //for (int i = 0; i < schedule.GetLength(0); i++)
    //{
    //    for (int j = 0; j < schedule.GetLength(1); j++)
    //    {
    //        if (i >= 6) schedule[i,j] = "Party";
    //        else schedule[i, j] = j >= 12 ? "work" : "slep";
    //    }
    //}

    //Debug.Log(schedule[3,15]);
    //Debug.Log(schedule[2,10]);
    //Debug.Log(schedule[5,18]);
    //Debug.Log(schedule[6,13]);
    //int[] numbers = new int[5]; //{1,2,3,4,5};
    //for (int i = 0; i < numbers.Length; i++)
    //{
    //    numbers[i] = i;
    //    Debug.Log(i);
    //}
    //Queue<int> queue = new Queue<int>();
    //queue.Enqueue(1);
    //queue.Enqueue(2);
    //queue.Enqueue(3);
    //queue.Enqueue(4);

    //int i = queue.Peek();
    //Debug.Log(i);
    //i = queue.Dequeue();
    //Debug.Log(i);
    //List<string>names = new List<string> { "Do","Bao", "Gi" };
    //  names.Add("Fe");
    //  names.Insert(1, "Zao");
    //  //names.Remove("Bo");
    //  int index = names.IndexOf("Bao");
    //  List<string> LastName = new List<string> {"Ti", "Ka", "So" };
    //  names.AddRange(LastName);
    //  names.Add("Bao");
    //  List<string> RangeNames = names.GetRange(4,3);
    //  Debug.Log(RangeNames.Count);
    //  Debug.Log(RangeNames.Any());
    //  foreach (string name in names)
    //  {
    //      Debug.Log(name);
    //  }
    //  //names.Sort();
    //  //names.Reverse();
    //  //Debug.Log(RangeNames[0]);
    //  //Debug.Log(RangeNames[1]);
    //  //Debug.Log(RangeNames[2]);
    //  //names.Clear();
    //  //Debug.Log(names.Contains("Bao"));
    //  //names.RemoveRange(0,4);
    //  //Debug.Log(names.Contains("Bao"));
    //  //Debug.Log(names[0]);
}
