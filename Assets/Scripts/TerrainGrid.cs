using UnityEngine;
using System.Collections;

public class TerrainGrid : MonoBehaviour 
{
	//publics
	public Space[] mSpacesGroundFloor; 
	public Space[] mSpacesSecondFloor;

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public bool SpaceFull(int ID)
	{
		return mSpacesGroundFloor[ID].IsFull ();
	}
}
