using UnityEngine;
using System.Collections;

public class testscr : MonoBehaviour {
	public Transform cube;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void moveleft() {
		cube.position += Vector3.left;

	
	}
	public void moveright() {
		cube.position += Vector3.right;
	
	}
}
