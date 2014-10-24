using UnityEngine;
using System.Collections;

public class Space : MonoBehaviour 
{
	//publics
	public int mID;

	//privates
	private bool mFull = false;
	public bool mShop = false;
	
	void MoveToSpace()
	{
		mFull = true;
	}

	void LeaveSpace()
	{
		mFull = false;
	}

	public bool IsFull()
	{
		if (mFull == true) 
		{
			return true;
		} 
		else 
		{
			return false;
		}
	}

	public bool IsShop()
	{
		if (mShop == true) 
		{
			return true;
		} 
		else 
		{
			return false;
		}
	}
}
