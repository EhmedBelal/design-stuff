using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	void OnEnable()
	{
		//Subscribe to OnClicked event on OnEnable. So it can be called on each invocation of OnClick  
		EventManager.OnClicked +=TeleportItem;
		print("Enabled");
	}

	void OnDisable()
	{
		//Unsubscribe to OnClicked event on OnDisable, otherwise there'll be memory leaks.
		EventManager.OnClicked -=TeleportItem;
		print("Disabled");
	}

	void TeleportItem()
	{
		Vector3 pos = transform.position;
		pos.y = Random.Range(1.0f, 3.0f);
		transform.position = pos;
	}
}
