using UnityEngine;
using System.Collections;

public class Hand : MonoBehaviour 
{
	private GameObject[] Cards;
	private GameObject Self;
	public readonly int numberofcards;
	// Use this for initialization
	void Start ()
	{
		Cards.GetLength (5);
	}

	void addCard(GameObject card)
	{
		Cards.SetValue(card,numberofcards);
	}

	void Showhand ()
	{
		//Display players hand
	}

	// Update is called once per frame
	void Update ()
	{
	
	}
}
