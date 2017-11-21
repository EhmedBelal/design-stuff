
//Multi-cast delegate be used to represent multiple methods at the same time

using UnityEngine;
using System.Collections;

public class Multicast : MonoBehaviour {

    delegate void MultiDelegate();
    MultiDelegate myMultiDelegate;

    void Start() { 
		//multi-casting a delegate variable by assigning mulitple methods to a single delegate
		myMultiDelegate += PowerUp;
		myMultiDelegate += TurnRed;

		//it's always a good idea to check if the delegate isn't empty. Otherwise the delegate will flag errors
		if(myMultiDelegate!=null)
		{
			myMultiDelegate();
		}

		//removing a method from the delegate
		myMultiDelegate -=PowerUp;
		myMultiDelegate -=TurnRed;
    }

    void PowerUp() {
        print("Orb is powering up!");
    }

    void TurnRed() {
        GetComponent<Renderer>().material.color = Color.red;
        
		print ("Orb color is: "+Color.red);
    }
}
