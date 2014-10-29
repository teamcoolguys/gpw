using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	//privates
	private Hand Hand;
	private bool moveLimitReached;
	private bool attackLimitReached;
	private Space currentSpace;

	//publics
	public Deck mDeck;

	public GameObject Self;
	
	public int mHealth;
	public int mDefense;
	public int mAttack;
	public int mRunSpeed;
	public int mSpeed;
	public int mStealhSpeed;


	public int mInfamy;//

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

	public void SetCurrentSpace(Space nextSpace)
	{
		move.MoveSpaces (nextSpace.transform);
		currentSpace = nextSpace;
	}

	public Transform FindCurrentSpace()
	{
		return currentSpace.transform;
	}

	Transform returnPlayerPoint()
	{
		return Self.transform;
	}

	void MoveSpaces(Transform spaceTransform)
	{
		charModel.transform.position = spaceTransform.position;
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
