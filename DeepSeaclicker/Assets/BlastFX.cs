using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class BlastFX : MonoBehaviour
{
    public float amount;
    public float duration;
    public int vibrato;
    public Transform background;

    // Start is called before the first frame update
    void Start()
    {
        // HACK
        FindObjectOfType<ClickedManager>().onCrit += OnCrit;
        FindObjectOfType<HarpoonSkill>().OnActivate += OnHarpoonActivate;
        FindObjectOfType<ACSkill>().OnActivate += OnACSkillActivate;
    }

    private void OnACSkillActivate()
    {
        BigShake();
    }

    private void OnHarpoonActivate()
    {
        BigShake();
    }

    private void BigShake()
    {
        background.transform.rotation = Quaternion.identity;
        background.localScale = Vector3.one;
        background.DOShakeRotation(duration * 2.0f, amount * 50f, vibrato);
        background.DOPunchScale(new Vector3(-amount, -amount), duration, vibrato);
        transform.localScale = Vector3.one;
        transform.DOPunchScale(new Vector3(amount, amount), duration, vibrato);
    }

    private void OnCrit()
    {
        transform.DOPunchScale(new Vector3(amount / 1.5f, amount / 1.5f), duration, vibrato);
    }

    // Update is called once per frame
    void Update()
    {
    }
}