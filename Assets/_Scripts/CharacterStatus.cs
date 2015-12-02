﻿// Files:			CharacterStatus.cs
//
// Author:			Sangbeom Yi
// Description:		Common Character Status
//
// Revision History 11/11/2015 file created
//
//
// Last Modified by	11/11/2015

using UnityEngine;
using System.Collections;

public class CharacterStatus : MonoBehaviour {
	// Player Data.
	public int HP = 100;
	public int MaxHP = 100;
	public int Pow = 10;
	public int Dex = 10;

	public GameObject lastAttackTarget = null;

	// Name of Character.
	public string characterName = "Player";

	// Player Status.
	public bool attacking = false;
	public bool died = false;
	
}
