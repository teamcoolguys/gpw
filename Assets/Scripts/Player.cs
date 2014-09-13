using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private GameObject Hand;
	public int mHealth;
	public int mDefense;
	public int mAttack;
	public int mMovement;
	public int mInfamy;
	public int mRange;

	private GameObject Self;

	private GameObject Deck;	//needs to be made
	enum PlayerModel
	{
		char1,
		char2,
		char3
		//etc

	}
	// Use this for initialization
	void Start () {
	
	}

	void MovePhase() {
		//Player Movement
	}

	void AttackPhase() {
		//player attack
	}

	void EndPhase() {
		//player end step
	}

	void UseCard() {
		// player uses card
	}

	void TakeDamage() {
		//pkayer takes damage
	}
	// Update is called once per frame
	void Update () {
	
	}
}
