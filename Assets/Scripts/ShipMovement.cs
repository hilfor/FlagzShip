﻿using UnityEngine;
using System.Collections;

public class ShipMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Move(Vector3 position)
    {
        transform.position = position;
    }
}
