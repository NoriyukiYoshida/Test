using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MyButton : MonoBehaviour {

	private int clickCount = 0;
	private Text text = null;


	void Start(){

		text = gameObject.transform.Find ("Text").GetComponent<Text>();
	}

	/// ボタンをクリックした時の処理
	public void OnClick() {

		text.text = "Click " + clickCount;
		clickCount++;
	}
}