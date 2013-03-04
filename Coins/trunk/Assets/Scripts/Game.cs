using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{
	public bool IS_SOUND = true;
	public  int K_BONUS = 10;
	public  int K_BUY_COINS = 1000;
	public  int K_BEGIN_COINS = 500;
	public  int K_BET_NORMAL_COINS = 60;
	public int mTotalCoint = 0;
	public int mBetCoins = 0;
	public int mLastWin = 0;
	string[]listSpinName =
	{
		"AnimatingSpriteSpin00",
		"AnimatingSpriteSpin01",
		"AnimatingSpriteSpin02",
		
		"AnimatingSpriteSpin10",
		"AnimatingSpriteSpin11",
		"AnimatingSpriteSpin12",
		
		"AnimatingSpriteSpin20",
		"AnimatingSpriteSpin21",
		"AnimatingSpriteSpin22",
		
		"AnimatingSpriteSpin30",
		"AnimatingSpriteSpin31",
		"AnimatingSpriteSpin32",
		
		"AnimatingSpriteSpin40",
		"AnimatingSpriteSpin41",
		"AnimatingSpriteSpin42",
		
	};
	public OTAnimatingSprite[]listSpin;
	
	void initConstant ()
	{
		K_BUY_COINS = 1000;
		IS_SOUND = true;
		K_BET_NORMAL_COINS = 60;
		K_BEGIN_COINS = 500;
		K_BONUS = 10;
		
		
		listSpin = new OTAnimatingSprite[listSpinName.Length];
		for (int i = 0; i < listSpinName.Length; i++) {
			listSpin [i] = OT.AnimatingSprite (listSpinName [i]);
		}
		
		mTotalCoint = K_BEGIN_COINS;				
		mBetCoins = K_BET_NORMAL_COINS;
		
	}

	void updateUI ()
	{
		updateTotalCoins ();
		updateBetCoins ();
	}

	public void updateLastWin ()
	{	
		GameObject game = GameObject.Find ("txt_LastWin");
		OTTextSprite text = game.GetComponent<OTTextSprite> ();
		
		text.text = "" + mLastWin + ".00";
	}
	
	public void updateBetCoins ()
	{	
		GameObject game = GameObject.Find ("txt_Bet");
		OTTextSprite text = game.GetComponent<OTTextSprite> ();
		
		text.text = "" + mBetCoins + ".00";
	}
	
	public void updateTotalCoins ()
	{	
		GameObject game = GameObject.Find ("txt_TotalCoins");
		OTTextSprite text = game.GetComponent<OTTextSprite> ();
		
		text.text = "" + mTotalCoint + ".00";
	}
	
	// Use this for initialization
	void Start ()
	{
		initConstant ();
		updateUI ();
	}

	public bool isSound ()
	{		
		return IS_SOUND;				
	}
	public void showMsg(string msg)
	{
			GameObject gameObject = GameObject.Find ("txt_Msg");
			MsgGame msg1 = gameObject.GetComponent<MsgGame> ();
			msg1.show (msg);
	}
	
	
}
