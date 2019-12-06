﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MainCannonTween : MonoBehaviour
{
	public Renderer mainCannon;
	public ClickedManager clickManager;

	public void OnEnable()
	{
		clickManager.OnAutoAttack += MainCannonFire;
	}
	public void OnDisable()
	{
		clickManager.OnAutoAttack -= MainCannonFire;
	}
	public void MainCannonFire()
	{
		Debug.Log("what's up guys like and subrcr");
		transform.DOPunchScale(new Vector3(0.1f, 0.1f, 0.1f), 0.1f, 10, 2f);
	}

}
