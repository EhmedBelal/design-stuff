using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DelegateNeoImp : MonoBehaviour {

    DelegateNeo delObj;

    //Local delegate declaration.
    delegate void MyLocalDelegate();
    MyLocalDelegate LocalDelegate;

    void Awake()
    {
        delObj = new DelegateNeo("delegate object");

        //Delegate instantiation.
        delObj.OnSimpleDelegate = new DelegateNeo.SimpleDelegate(DelFunc);

        //Local delegate initialization.
        LocalDelegate = new MyLocalDelegate(OnLocalCallback);
    }
    
    void Start() 
    {
        //Delegate invoked.
        delObj.OnSimpleDelegate();

        //Local delegate invocation
        LocalDelegate();
    }

    //Callback method.
    void DelFunc() 
    {
        Debug.Log("Callback invoked");
    }

    void OnLocalCallback() {
        Debug.Log("Local callback invoked");
    }
}
