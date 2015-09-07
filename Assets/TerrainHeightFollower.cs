using UnityEngine;
using System.Collections;

public class TerrainHeightFollower : MonoBehaviour {
	public float heightOffset = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void LateUpdate () {
		Vector3 pos = transform.position;
		
		pos.y = Terrain.activeTerrain.SampleHeight(pos)+heightOffset;
		
		transform.position = pos;
	}
}
