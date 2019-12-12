using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HarpoonTween : MonoBehaviour
{

    public HarpoonSkill harpoonSkill;
    public Vector3 startingScale;

    // Start is called before the first frame update
    void OnEnable()
    {
        harpoonSkill.OnActivate += HarpoonFX;
        startingScale = transform.localScale;
    }
    private void OnDisable()
    {
        harpoonSkill.OnActivate -= HarpoonFX;
    }

    // Update is called once per frame
    public void HarpoonFX()
    {
        transform.localScale = startingScale;
        transform.DOPunchScale(new Vector3(0.1f, 0.1f, 0.1f), 0.1f, 10, 2f);
    }
}
