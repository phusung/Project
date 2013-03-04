using UnityEngine;
using System.Collections;

public class BuyCoins : MonoBehaviour
{
	
	Game game ;

	void Start ()
	{
		GameObject gameObject = GameObject.Find ("GameObject1");
		game = gameObject.GetComponent<Game> ();
	}

	void OnMouseDown ()
	{
		
		if (game.isSound ()) {
			
			audio.Play ();
		}
		
		game.mTotalCoint += game.K_BUY_COINS;
		game.updateTotalCoins ();
		
		
		
	}
	
}
