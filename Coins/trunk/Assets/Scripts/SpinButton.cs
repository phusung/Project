using UnityEngine;
using System.Collections;

public class SpinButton : MonoBehaviour
{
	Game game ;

	void Start ()
	{
		GameObject gameObject = GameObject.Find ("GameObject1");
		game = gameObject.GetComponent<Game> ();
	}
	
	bool isRunning = false;
	
	void OnMouseDown ()
	{	
		if (game.isSound ()) {
			audio.Play ();
		}
		updateSpin ();     
	}

	void updateSpin ()
	{
		if (isRunning) {
			StopSpin ();
		} else {
			startSpin ();
		}
	}
	
	void startSpin ()
	{
		// out of memory
		if ((game.mTotalCoint < game.mBetCoins) || (game.mTotalCoint == 0)) {
			game.showMsg("Please press \"Buy Coins \" to continue.");
			
			return;
		}
		
		if (!isRunning) {
			isRunning = true;
			// run animation							
			for (int i = 0; i < game.listSpin.Length; i++) {
			
				game.listSpin [i].Play ();
			}			
			
			game.mTotalCoint -= game.mBetCoins;						
		}
	}

	void StopSpin ()
	{
		if (isRunning) {
			isRunning = false;
			for (int i = 0; i < game.listSpin.Length; i++) {
				game.listSpin [i].Stop ();
				
			}
			
			
			int temp = computerCoins ();			
			if (temp > 0) {
				game.mLastWin = temp;
				game.updateLastWin ();
				
				game.mTotalCoint += game.mLastWin;
				game.showMsg("You win " + game.mLastWin);
			}									
		}
		game.updateTotalCoins ();
	}

	int computerCoins ()
	{
		int winCoins = 0;
		if (isRunning == false) {
			//	frameIndex
			for (int i = 0; i < game.listSpin.Length -2; i+=3) {
				
				
				if (((i % 3) == 0)
					&& (game.listSpin [i].frameIndex == game.listSpin [i + 1].frameIndex) 
					&& (game.listSpin [i].frameIndex == game.listSpin [i + 2].frameIndex)) {
					winCoins += game.K_BONUS * game.mBetCoins;					
					Debug.Log (" win " + winCoins);
				}
			}
		}
		return winCoins;
	}

	
	
}
