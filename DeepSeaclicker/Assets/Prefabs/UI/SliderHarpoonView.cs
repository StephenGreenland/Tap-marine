using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderHarpoonView : MonoBehaviour
{
    public HarpoonSkill harpoonSkill;
    public Slider slider;
    
    // Update is called once per frame
    void Update()
    {
        slider.value = harpoonSkill.cooldownTime;
    }
}
