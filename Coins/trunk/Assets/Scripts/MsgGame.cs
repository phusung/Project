using UnityEngine;
using System.Collections;

public class MsgGame : MonoBehaviour
{
	int time ;
	// Use this for initialization
	void Start ()
	{
		renderer.enabled = false;
		time = 0;
	}
	
	
	public void show (string msg)
	{
		renderer.enabled = true;
		OTTextSprite text = GetComponent<OTTextSprite> ();
		text.text = msg;
	}

	void Update ()
	{
		if (renderer.enabled) {
			time++;
			if (time >= 100) {
				renderer.enabled = false;
			}
		} else {
			time = 0;
		}
	}
	
}
