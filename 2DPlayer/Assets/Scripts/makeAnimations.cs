using UnityEngine;
using System.Collections;

public class makeAnimations : MonoBehaviour {
	
	public GameObject sprite;
	public string axis;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetAxisRaw (axis) > 0 ) {
			sprite.gameObject.transform.eulerAngles = new Vector2(0,0);
		}
		
		if (Input.GetAxisRaw (axis) < 0 ) {
			sprite.gameObject.transform.eulerAngles = new Vector2(0,180);
		}
		
	}
}
