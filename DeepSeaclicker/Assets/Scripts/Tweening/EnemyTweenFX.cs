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
		clickManager.onCrit -= OnCritical;
	}

	private void OnHealthChanged(float amount)
	{
		transform.DOPunchScale(new Vector3 (0.05f,0.05f,0.05f), 0.1f, 10, 2f);
	}

	public void OnCritical()
	{

		rend.material.color = new Color(1f, 0.5f, 0.5f); rend.material.DOColor(Color.white, 0.5f);

		transform.DOShakePosition(0.3f, 1f, 10, 90, false, true);

		//transform.DOPunchScale(new Vector3(0.1f, 0.11f, 0.1f), 0.05f, 10, 2f);
	}
}
