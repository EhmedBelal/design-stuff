using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateNeoImp : MonoBehaviour {

    DelegateNeo delObj;

    void Awake()
    {
        delObj = new DelegateNeo("delegate object");

        //Delegate instantiation.
        delObj.OnSimpleDelegate = new DelegateNeo.SimpleDelegate(DelFunc);
    }
    
    void Start() 
    {
        //Delegate invoked
        delObj.OnSimpleDelegate();
    }

    //Callback method
    void DelFunc() 
    {
        Debug.Log("Callback invoked");
    }
}
