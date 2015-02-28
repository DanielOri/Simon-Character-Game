using UnityEngine;
using System.Collections;

public class SwitchDimension : MonoBehaviour {

	public GameObject player;
	int dimension;

	// Use this for initialization
	void Start () {
		dimension = 1;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Z)){

			if (dimension == 1){
				player.transform.position = new Vector2 (player.transform.position.x + 1996, player.transform.position.y);
				dimension = 2;
			}else if (dimension == 2) {
				player.transform.position = new Vector2 (player.transform.position.x - 2004, player.transform.position.y);
				dimension = 1;
			}
		}
	
	}
}
