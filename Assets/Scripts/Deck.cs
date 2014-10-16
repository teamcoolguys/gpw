//added functionality throughout the entire class
//Wyatt

using UnityEngine;
using System.Collections;

public class Deck : MonoBehaviour
{
	//publics
	private int count;
	
	//privates
	public GameObject[] mCards;

	// Use this for initialization
	void Start () 
	{
		count = 0;
	}

	void Shuffle ()
	{
		for(int i = 0; i < mCards.Length; ++i)
		{
			float random = Random.value % mCards.Length;
			GameObject temp = mCards[(int)random];
			mCards[(int)random] = mCards[i];
			mCards[i] = temp;
		}
	}

	GameObject Draw()
	{
		GameObject nextCard = null;
		if(!this.isEmpty())
		{
			nextCard = mCards[count];
			count++;
		}
		return nextCard;
	}

	bool isEmpty()
	{
		return mCards.Length == 0;
	}

//	void Discard ()
//	{
//		//In case of deck discard 
//		//damn designers not making up minds
//	}
//
//	void Regain ()
//	{
//		//In case of regain discarded cards
//	}
//	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
