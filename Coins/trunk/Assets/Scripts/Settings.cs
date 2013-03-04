using UnityEngine;
using System.Collections;

public class Settings : MonoBehaviour
{
	void Start ()
	{
		audio.Play ();
	}

	void OnMouseDown ()
	{
		GameObject gameObject = GameObject.Find ("GameObject1");
		Game game = gameObject.GetComponent<Game> ();
		
		if (game.isSound ()) {
			game.IS_SOUND = false;
			if (audio.isPlaying == true) {
				audio.Stop ();
			}
			// stop sound
		} else {
			game.IS_SOUND = true;
			if (audio.isPlaying == false) {
				audio.Play ();
			}
		}
		
		
	
	}
}
