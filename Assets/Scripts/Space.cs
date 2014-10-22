using UnityEngine;
using System.Collections;

public class Space : MonoBehaviour 
{

	public int mID;
	public bool mFull = false;
	
	void MoveToSpace()
	{
		mFull = true;
	}

	bool IsFull()
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
}
