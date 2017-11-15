using UnityEngine;
using System.Collections;

public class Delegate : MonoBehaviour {

    delegate void MyDelegate(int num);//template for delegate, it dictates the type of methods we can assign to it
    MyDelegate myDelegate;

    void Start() {
        myDelegate = PrintNum;
        myDelegate(50);//myDelegate is called just like a function as PrintNum()

        myDelegate = DoubleNum;
        myDelegate(50);
    }

    void PrintNum(int num)
    {
        print("Print num: " + num);
    }

    void DoubleNum(int num) {
        print("Double num: " + (num * 2));
    }
}
