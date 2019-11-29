using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;



public class EnemyTweenFX : MonoBehaviour
{

	public Health health;
	public ClickedManager clickManager;
	public Renderer rend;
	
	private void OnEnable()
	{
		clickManager = GameObject.FindGameObjectWithTag("ClickManager").GetComponent<ClickedManager>();
		health.OnChanged += OnHealthChanged;
		clickManager.onCrit += OnCritical;
	}

	private void OnDisable()
	{
		health.OnChanged -= OnHealthChanged;
	}

	private void OnHealthChanged(float amount)
	{
		transform.DOPunchScale(new Vector3 (0.05f,0.05f,0.05f), 0.05f, 10, 2f);
	}

	public void OnCritical()
	{

		rend.material.color = new Color(1f, 0.5f, 0.5f); rend.material.DOColor(Color.white, 0.5f);
		transform.DOPunchScale(new Vector3(0.15f, 0.15f, 0.15f), 0.7f, 10, 2f);
	}
}
