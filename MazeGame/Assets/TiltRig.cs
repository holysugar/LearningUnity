﻿using UnityEngine;
using System.Collections;

public class TiltRig : MonoBehaviour {

    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        transform.rotation =
            Quaternion.AngleAxis(Input.GetAxis("Horizontal") *  5.0f, Vector3.forward) *
            Quaternion.AngleAxis(Input.GetAxis("Vertical"  ) * -5.0f, Vector3.right);
    }
}
