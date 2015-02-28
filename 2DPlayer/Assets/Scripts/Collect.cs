using UnityEngine;
using System.Collections;

public class Collect : MonoBehaviour {

	CollectableManager gm;
	bool got;

	public GameObject cube;
	int state;

	// Use this for initialization
	void Start () {

		state = 0;
		gm = GameObject.Find("_Game Manager").GetComponent<CollectableManager>();

	}

	void Update(){

		animateCube();

	}

	
	void OnTriggerEnter2D (Collider2D player) {

		if (player.gameObject.name == "Player" && !got){

			got = !got;
			gm.SendMessage("addCollection");
			StartCoroutine("eraseCollectable");

		}

	}

	IEnumerator eraseCollectable(){

		state = 1;

		yield return new WaitForSeconds(0.1f);

		state = 2;
		
		yield return new WaitForSeconds(0.1f);

		Destroy(transform.parent.gameObject);

	}

	void animateCube(){

		if (state == 1){
			cube.transform.localScale += Vector3.one * .2f;
		}
		if (state == 2){
			cube.transform.localScale -= Vector3.one * .3f;
		}

	}

}
