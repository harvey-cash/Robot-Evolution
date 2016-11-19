﻿using UnityEngine;
using System.Collections;
using System;
using System.Linq;
using System.Collections.Generic;

public class Main : MonoBehaviour {

	public CraftinPillars pillarscript;  
	public Level1 lvl1script; 
	public EndofLvl newLvl;
	public bool PillarUp; 
	public string currentLvl;


	// Use this for initialization
	void Start () {
		PillarUp = true; 
	}


	// Update is called once per frame
	void Update () 
	{
		currentLvl = newLvl.Next();
		if (PillarUp)	
			pillarscript.pillarUp(0.001f);
		if (!PillarUp)
			pillarscript.pillarUp(-0.01f);
		if (currentLvl == "Lvl1")
			lvl1script.FirstLvl(0.01f);
		if (currentLvl != "Lvl1")
			lvl1script.FirstLvl(-0.01f);
		
	}

}