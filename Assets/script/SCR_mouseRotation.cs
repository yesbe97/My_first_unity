﻿using UnityEngine;
using System.Collections;

public class SCR_mouseRotation : MonoBehaviour {

    void Update()
    {
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.z, 10);
        Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePos);
        lookPos = lookPos - transform.position;
        float angle = Mathf.Atan2(lookPos.z, lookPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle*10, Vector3.down); // Turns Right
        transform.rotation = Quaternion.AngleAxis(angle*10, Vector3.up); //Turns Left

    }
}
