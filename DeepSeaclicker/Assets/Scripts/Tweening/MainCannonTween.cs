using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MainCannonTween : MonoBehaviour
{
	public Renderer mainCannon;
	public ClickedManager clickManager;
	public Vector3 startingScale;

	public void OnEnable()
	{
		clickManager.OnAutoAttack += MainCannonFire;
		startingScale = transform.localScale;
	}
	public void OnDisable()
	{
		clickManager.OnAutoAttack -= MainCannonFire;
	}
	public void MainCannonFire()
	{
		Debug.Log("what's up guys like and subrcr");
		transform.localScale = startingScale;
		transform.DOPunchScale(new Vector3(0.1f, 0.1f, 0.1f), 0.1f, 10, 2f);
	}

}
