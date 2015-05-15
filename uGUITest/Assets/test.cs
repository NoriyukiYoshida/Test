using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.Find("Canvas/Text").GetComponent<Text>().text = "テキスト変更";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
