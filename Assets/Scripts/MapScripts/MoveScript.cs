using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	//publics
	public GameObject charModel;

	//privates

	public void MoveSpaces(Transform spaceTransform)
	{
		charModel.transform.position = spaceTransform.position;
	}
}
