using UnityEngine;
using System.Collections;

public class TerrainHeightFollower : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void LateUpdate () {
		Vector3 pos = transform.position;
		
		pos.y = Terrain.activeTerrain.SampleHeight(pos)+20;
		
		transform.position = pos;
	}
}
