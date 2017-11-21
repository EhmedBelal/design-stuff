using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour {
	
	public delegate void ClickAction();

	//event: indicates that it's an event. Given it's static so it can be used globally
	public static event ClickAction OnClicked;

	void OnGUI(){
		if(GUI.Button(new Rect(Screen.width/2-50,5,100,50),"Click")){
			if(OnClicked != null)
				OnClicked();
		}
	}
}