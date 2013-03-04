using UnityEngine;
using System.Collections;

public class BetMax : MonoBehaviour
{
	
	Game game ;

	void Start ()
	{
		GameObject gameObject = GameObject.Find ("GameObject1");
		game = gameObject.GetComponent<Game> ();
	}

	void betMax ()
	{
		
		game.mBetCoins = game.mTotalCoint;
		game.updateBetCoins ();
		
	}

	void normal ()
	{
		
		game.mBetCoins = game.K_BET_NORMAL_COINS;
		game.updateBetCoins ();
	}

	void OnMouseDown ()
	{
		if (game.isSound ()) {
			
			audio.Play ();
		}
		if (game.mBetCoins == game.K_BET_NORMAL_COINS) {
			betMax ();
		} else {
			normal ();
		}
		
	}
}
