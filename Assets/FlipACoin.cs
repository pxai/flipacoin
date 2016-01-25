using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FlipACoin : MonoBehaviour {
	public Text gameText;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("h")) {
			Debug.Log ("heads was pressed");
			gameText.text = "You've selected heads";
			if (flip () == "heads") {
				gameText.text += "\n and you WON!";
			} else {				
				gameText.text += "\n and you've FAILED";
			}
		} else if (Input.GetKeyDown("t")) {
			Debug.Log ("tails was pressed");
			gameText.text = "You've selected tails";
			if (flip () == "tails") {
				gameText.text += "\n and you've WON!";
			} else {
				gameText.text += "\n and you've FAILED";
			}
		}
	}

	/**
	 * This methods simulates the flip of a coin
	 */
	private string flip () {
		System.Random random = new System.Random ();
		if (random.Next(2)==0) {
			Debug.Log("Result: heads");
			return "heads";
		} else {
			Debug.Log("Result: tails");
			return "tails";
		}
	}
}
