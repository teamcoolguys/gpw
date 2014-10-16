using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	//privates
	private Hand Hand;
	private GameObject Self;
	private bool moveLimitReached;
	private bool attackLimitReached;
	//publics
	public Deck mDeck;
	public int mHealth;
	public int mDefense;
	public int mAttack;
	public int mRunSpeed;
	public int mSpeed;
	public int mStealhSpeed;
	public int mInfamy;
	public int mRange;

	enum PlayerModel
	{
		char1,
		char2,
		char3
		//etc
	}

	// Use this for initialization
	void Start ()
	{
	
	}

	void MovePhase()
	{
		//Player Movement
		moveLimitReached = true;
	}

	void AttackPhase()
	{
		//player attack
		attackLimitReached = true;
	}

	bool EndPhase()
	{
		//player end step
		return true;
	}

	void UseCard()
	{
		// player uses card
	}

	void TakeDamage()
	{
		//player takes damage
	}

	// Update is called once per frame
	void PlayerTurn ()
	{
		if(!moveLimitReached)
		{
			MovePhase ();
		}
		if(!attackLimitReached)
		{
			AttackPhase();
		}
	}
}
