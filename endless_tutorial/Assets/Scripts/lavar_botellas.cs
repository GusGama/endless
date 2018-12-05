﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavar_botellas : MonoBehaviour {
    public GameObject obj1;
    public GameObject obj2;
    private Animator anim1;
    private Animator anim2;
    private bool trigger;

	// Use this for initialization
	void Start () {
        anim1 = obj1.GetComponent<Animator>();
        anim2 = obj2.GetComponent<Animator>();
        trigger = false;
    }
    // Update is called once per frame
    public void animacion()
    {
        if (trigger)
        {
            anim1.SetBool("activo", true);
            anim2.SetBool("activo", true);
        }
    }
}
