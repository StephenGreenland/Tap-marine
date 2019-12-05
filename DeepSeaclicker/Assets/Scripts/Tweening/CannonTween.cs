using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CannonTween : MonoBehaviour
{

    public ACSkill cannonSkill;

    // Start is called before the first frame update
    void OnEnable()
    {
        cannonSkill.OnActivate += HarpoonFX;
    }
    private void OnDisable()
    {
        cannonSkill.OnActivate -= HarpoonFX;
    }

    // Update is called once per frame
    public void HarpoonFX()
    {
        transform.DOPunchScale(new Vector3(0.1f, 0.1f, 0.1f), 0.1f, 10, 2f);
    }
}
