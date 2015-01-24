﻿using UnityEngine;
using System.Collections;

public class JointManager : MonoBehaviour {

    public bool IsPlayer = true;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Parachute"))
        {
            return;
        }

        if ((IsPlayer && collision.gameObject.tag != "Player") || (!IsPlayer && collision.gameObject.tag != "Enemy"))
        {
            Destroy(GetComponent<Joint2D>());
            tag = "Untagged";
            transform.parent = null;
        }
    }
}
