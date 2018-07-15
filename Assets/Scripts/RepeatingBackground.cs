using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

    private BoxCollider2D GroundCollider;
    private float GroundHorizontalLength;

	// Use this for initialization
	void Start () {

        GroundCollider = GetComponent<BoxCollider2D>();
        GroundHorizontalLength = GroundCollider.size.x; 
        
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x < -(GroundHorizontalLength))
        {
            RepostionBackground();
        }

	}

    private void RepostionBackground()
    {
        Vector2 GroundOffset = new Vector2(40.95f, 0);
        transform.position = (Vector2)transform.position + GroundOffset;

    }
}
