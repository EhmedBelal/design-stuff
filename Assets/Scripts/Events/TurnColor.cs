using UnityEngine;
using System.Collections;

public class TurnColor : MonoBehaviour {
	void OnEnable(){
		EventManager.OnClicked +=ChangeColor;
	}

	void OnDisable(){
		EventManager.OnClicked -=ChangeColor;
	}

	void ChangeColor(){
		Color _color = new Color(Random.value,Random.value,Random.value);
		renderer.material.color=_color;
	}
}
