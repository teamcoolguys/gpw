using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour {

	//publics
	public TerrainGrid mGroundFloor;
	public TerrainGrid mSecondFloor;
	public GameObject[] player;

	//privates
	private int currentPlayer;

	// Use this for initialization
	void Start () 
	{
		currentPlayer = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			RaycastHit hitInfo = new RaycastHit();
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if(Physics.Raycast(ray, out hitInfo, 100))
			{
				Debug.Log(hitInfo.collider.name);
				int nextSpace = int.Parse (hitInfo.collider.name);

				Debug.Log(nextSpace);

				player[currentPlayer].moveSpaces(nextSpace);
			}
		}
	}
}
