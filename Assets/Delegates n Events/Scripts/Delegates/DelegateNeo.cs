using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DelegateNeo 
{
    //Private
    private string name;

    //Constructor
    public DelegateNeo(string _name)
    {
        name = _name;
    }

    //Delegate declaration
    public delegate void SimpleDelegate();
    public SimpleDelegate OnSimpleDelegate;
}
